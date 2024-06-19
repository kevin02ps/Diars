using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace InversionesHermanos
{
    public partial class Comprobante : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        ApiDni_Ruc ApisPeru = new ApiDni_Ruc();

        int MontoTotal { get; set; }
        int id_pedido { get; set; }
        private Point _mouseStartPoint;
        int alto { get; set; }

        int XPDF = 500;
        int YPDF = 300;

        private Pedidos pedido;
        private Login Login;
        public Comprobante(Pedidos pedido, Login login)
        {
            InitializeComponent();
            this.pedido = pedido;
            this.Login = login;
            CargarDatos();
        }

        private string consultarClientePorDni(string dni)
        {
            try
            {
                if (dni.Length == 11)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    lblRuc.Text = "Ruc: " + dni;
                    lblFoB.Text = "FACTURA";
                    lblNumeroFactura.Text = "Factura: ";
                    return respuesta.razonSocial.ToString();
                }
                else if (dni.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    lblRuc.Text = "Dni: " + dni;
                    lblFoB.Text = "BOLETA";
                    lblNumeroFactura.Text = "Boleta: ";
                    return respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                }
                return null;
            }
            catch
            {
                return dni;
            }
        }

        public void CargarDatos()
        {
            ArrayList cliente = conexion.ObtenerClientePorId(pedido.id_cliente);
            lblCliente.Text = "Cliente:  " + consultarClientePorDni(Convert.ToString(cliente[0]));
            lblFecha.Text = "Fecha: " + DateTime.Today.ToString("dddd dd 'de' MMMM 'del' yyyy");
            lblTipoDePago.Text = "Tipo de pago: " + pedido.TipoPagoText;
            this.alto = 270;


            foreach (DataRow fila in pedido.tabla.Rows)
            {
                // Obtener los datos de cada fila
                string cantidad = fila[2].ToString();
                string producto = fila[1].ToString();
                string precio = fila[3].ToString();
                string precioT = fila[4].ToString();

                // Crear Labels para mostrar los datos
                Label labelCantidad = new Label();
                labelCantidad.Text = cantidad;
                labelCantidad.AutoSize = true; // Ajustar automáticamente el tamaño
                labelCantidad.Location = new System.Drawing.Point(65, this.alto); // Posición en el formulario
                this.Controls.Add(labelCantidad);

                Label labelProducto = new Label();
                labelProducto.Text = producto;
                labelProducto.AutoSize = true; // Ajustar automáticamente el tamaño
                labelProducto.Location = new System.Drawing.Point(175, this.alto); // Posición en el formulario
                this.Controls.Add(labelProducto);

                Label labelPrecio = new Label();
                labelPrecio.Text = precio;
                labelPrecio.AutoSize = true; // Ajustar automáticamente el tamaño
                labelPrecio.Location = new System.Drawing.Point(435, alto); // Posición en el formulario
                this.Controls.Add(labelPrecio);

                Label labelPrecioT = new Label();
                labelPrecioT.Text = precioT;
                labelPrecioT.AutoSize = true; // Ajustar automáticamente el tamaño
                labelPrecioT.Location = new System.Drawing.Point(595, this.alto); // Posición en el formulario              
                this.Controls.Add(labelPrecioT);

                this.alto += 20;
                this.YPDF += 20;

                lblMontoTotal.Location = new System.Drawing.Point(515, this.alto + 20);
                this.Size = new System.Drawing.Size(750, 130 + this.alto);
            }
            // Calcular la suma de la columna "MiColumna" usando LINQ
            foreach (DataRow row in pedido.tabla.Rows)
            {
                MontoTotal += Convert.ToInt32(row[4]);
            }
            lblMontoTotal.Text += " " + MontoTotal;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToString("yyyy-MM-dd");

            //Agregar Pedido
            this.id_pedido = conexion.AgregarNuevoPedido(pedido.id_cliente, fecha, Login.id_empleado, this.MontoTotal, pedido.TipoPago);
            conexion.InsertarBoleta(fecha, true, this.id_pedido);

            //Agregar DetallePedido
            foreach (DataRow fila in pedido.tabla.Rows)
            {
                int idProducto = Convert.ToInt32(fila[0]);
                int cantidad = Convert.ToInt32(fila[02]);
                int precio = Convert.ToInt32(fila[3]);
                int precioT = Convert.ToInt32(fila[4]);
                conexion.AgregarNuevoDetallePedido(this.id_pedido, idProducto, cantidad, precio, precio * cantidad);
                conexion.RetirarProductos(idProducto, cantidad);
            }
            lblNumeroFactura.Text += " 0000" + this.id_pedido;

            buttonConfirmar.Visible = false;
            btnCerrar.Visible = false;

            ObtenerPdf();

            btnCerrar.Visible = true;
        }

        public void ObtenerPdf()
        {
            // Crear un bitmap con el tamaño de la ventana del formulario
            Bitmap screenshot = new Bitmap(this.Width, this.Height);

            // Capturar el contenido de la ventana del formulario
            this.DrawToBitmap(screenshot, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

            // Ruta donde se guardará el archivo PDF
            string ruta = "";
            if (Configuracion.UbiComprobante != null)
            {
                string ubi = Configuracion.UbiComprobante.Replace('\\', '/');
                ruta = ubi + "/Comprobante" + this.id_pedido + ".pdf";
            }
            else
            {
                ruta = "C:/Comprobante" + this.id_pedido + ".pdf";
            }

            // Crear un nuevo documento PDF
            Document doc = new Document(new iTextSharp.text.Rectangle(XPDF, YPDF));

            try
            {
                PdfWriter.GetInstance(doc, new System.IO.FileStream(ruta, System.IO.FileMode.Create));
                doc.Open();

                // Convertir el objeto Bitmap a un objeto iTextSharp.text.Image
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(screenshot, System.Drawing.Imaging.ImageFormat.Bmp);

                // Escalar la imagen para que se ajuste al tamaño del documento
                img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);

                // Centrar la imagen en el documento
                img.Alignment = iTextSharp.text.Image.ALIGN_CENTER | iTextSharp.text.Image.ALIGN_MIDDLE;


                // Agregar la imagen al documento
                doc.Add(img);

                Console.WriteLine("¡La conversión se ha completado con éxito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir la imagen a PDF: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close();
                }
            }
        }

        private void Comprobante_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Pen con el color y el grosor deseado
            Pen pen = new Pen(Color.DarkGray, 1);

            // Dibujar una línea desde (x1, y1) a (x2, y2)
            e.Graphics.DrawLine(pen, 55, 230, 665, 230);
            e.Graphics.DrawLine(pen, 55, 260, 665, 260);
            e.Graphics.DrawLine(pen, 55, 10 + this.alto, 665, 10 + this.alto);

            // Liberar los recursos del objeto Pen
            pen.Dispose();
        }

        private void Comprobante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseStartPoint = e.Location;
            }
        }

        private void Comprobante_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X - _mouseStartPoint.X + e.X, Location.Y - _mouseStartPoint.Y + e.Y);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Barra manipulable personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
