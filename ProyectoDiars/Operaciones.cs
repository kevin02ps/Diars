using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.Diagram.Core.Layout;
using System.Collections;
using DevExpress.CodeParser;
using System.Timers;


namespace InversionesHermanos
{
    public partial class Operaciones : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();
        ApiDni_Ruc ApisPeru = new ApiDni_Ruc();

        private static System.Threading.Timer _timer;
        public System.Threading.Timer timer;
        private Login Login;
        private bool isMaximized = false; // Estado de la ventana
        private Size originalSize; // Tamaño original de la ventana
        private Point originalLocation; // Ubicación original de la ventana
        private int borderSize = 2;
        public int id_usuario;
        public Operaciones(Login login)
        {
            InitializeComponent();
            this.id_usuario = login.id_usuario;
            timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            this.Login = login;
            if (Login.cargo == "admin")
            {
                lblEmpleado.Text = Login.cargo;
            }
            else
            {
                lblEmpleado.Text = Login.cargo + ", " + consultarClientePorDni(Convert.ToString(Login.dni));
            }

            /////tal vez no tenga efecto
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color

            //Preferencias segun cargo 
            switch (login.cargo)
            {
                case "GERENTE":
                    break;
                case "ADMINISTRADOR":
                    btnVentas.Enabled = false;
                    break;
                case "VENDEDOR":
                    btnProducto.Enabled = false;
                    btnProveedores.Enabled = false;
                    btnVentas.Enabled = false;  
                    break;
                case "admin":
                    break;
            }
        }

        public void TimerCallback(object state)
        {
            if (conexion.ObtneerEstadoUsuario(id_usuario) == 2)
            {
                // Obtener el formulario de tipo Operaciones que está activo
                Operaciones operacionesForm = Application.OpenForms.OfType<Operaciones>().FirstOrDefault();

                if (operacionesForm != null)
                {
                    // Desactivar el formulario en el hilo de la interfaz de usuario
                    operacionesForm.Invoke((MethodInvoker)delegate {
                        operacionesForm.Enabled = false;
                    });
                }
                // Detener el temporizador cambiando su intervalo a Timeout.Infinite
                timer?.Change(Timeout.Infinite, Timeout.Infinite);
                MessageBox.Show("Se ha iniciado sesión en otro dispositivo. Se cerrará la sesión actual.");

                if (operacionesForm != null)
                {
                    // Activar el formulario en el hilo de la interfaz de usuario
                    operacionesForm.Invoke((MethodInvoker)delegate {
                        operacionesForm.Enabled = true;
                    });
                }

                Application.Exit();
            }
        }

        private string consultarClientePorDni(string dni)
        {
            try
            {
                if (dni != null)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImtldmluLmdhcmNpYWxlbzIwMDJAZ21haWwuY29tIn0.3lFfBcpdwpuR779TI3YGVTbSqgXzhvy4brJ6-xA82RE");
                    return respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                }
            }
            catch
            {
                return Login.dni;
            }

            return null;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Empleado productos = new Empleado();
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Pedidos productos = new Pedidos(this.Login);
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btonClientes_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Clientes productos = new Clientes(Login);
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Proveedores productos = new Proveedores();
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Producto productos = new Producto();
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Consulta productos = new Consulta();
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            conexion.CambiarEstadoUsuario(Login.id_usuario, 2);
            Application.Exit();
        }

        private void Operaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.CambiarEstadoUsuario(Login.id_usuario, 2);
        }

        private void Operaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.CambiarEstadoUsuario(Login.id_usuario, 2);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); //limpiamos el panel
            Configuracion productos = new Configuracion();
            productos.TopLevel = false;
            panel.Controls.Add(productos);
            productos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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


        //Acoplamiento
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0X0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        //ajustar formulario
        private void Operaciones_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Restaurar la ventana al tamaño y ubicación originales
                this.Size = originalSize;
                this.Location = originalLocation;
                isMaximized = false;
            }
            else
            {
                // Maximizar la ventana
                originalSize = this.Size;
                originalLocation = this.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                isMaximized = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
