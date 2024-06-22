using InversionesHermanos.Conexion;
using ProyectoDiars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversionesHermanos
{
    public partial class Pedidos : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        ApiDni_Ruc ApisPeru = new ApiDni_Ruc();

        public int id_cliente { get; set; }
        public DataTable tabla { get; set; }

        public int TipoPago;
        public string TipoPagoText;
        public int StockProducto;

        private Login Login;
        public Pedidos(Login login)
        {
            InitializeComponent();
            this.Login = login;
        }

        private void txtIdCliente_MouseEnter_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.CargarTabla("Clientes");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtIdProducto_MouseEnter_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.CargarTabla("Producto");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Llene los campos");
            }
            else if (conexion.ObtenerClientePorId(Convert.ToInt32(txtIdCliente.Text)) == null)
            {
                MessageBox.Show("Cliente no encontrado");
            }
            else
            {
                ArrayList cliente = conexion.ObtenerClientePorId(Convert.ToInt32(txtIdCliente.Text));
                string dni = Convert.ToString(cliente[0]);
                consultarClientePorDni(dni);
                txtIdCliente.ReadOnly = true;
            }

        }

        private void consultarClientePorDni(string dni)
        {
            try
            {
                if (dni.Length == 11)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImtldmluLmdhcmNpYWxlbzIwMDJAZ21haWwuY29tIn0.3lFfBcpdwpuR779TI3YGVTbSqgXzhvy4brJ6-xA82RE");
                    lblNombreCliente.Text = respuesta.razonSocial.ToString();
                }
                else if (dni.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImtldmluLmdhcmNpYWxlbzIwMDJAZ21haWwuY29tIn0.3lFfBcpdwpuR779TI3YGVTbSqgXzhvy4brJ6-xA82RE");
                    lblNombreCliente.Text = respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                }
            }
            catch
            {
                lblNombreCliente.Text = dni;
            }
        }
        private void btnBuscarProductoAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                MessageBox.Show("Llene los campos");
            }
            else if (conexion.ObtenerProductoPorId(Convert.ToInt32(txtIdProducto.Text)) == null)
            {
                MessageBox.Show("Producto no encontrado");
                groupBoxPedidoPedido.Enabled = false;
                txtCantidadAgregar.Text = "";
                txtPrecioAgregar.Text = "";
            }
            else
            {
                ArrayList producto = conexion.ObtenerProductoPorId(Convert.ToInt32(txtIdProducto.Text));
                lblDescripcionProducto.Text = Convert.ToString(producto[1]);
                txtPrecioAgregar.Text = Convert.ToString(producto[2]);
                StockProducto = Convert.ToInt32(producto[3]);
                groupBoxPedidoPedido.Enabled = true;
            }
        }

        private void btnAceptarAgregar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantidadAgregar.Text) > StockProducto)
            {
                MessageBox.Show("Cantidad no disponible");
            }
            else
            {
                if (txtCantidadAgregar.Text == "")
                {
                    MessageBox.Show("Llene los campos");
                }
                else
                {
                    bool existe = false;
                    string ID = txtIdProducto.Text;
                    int cantidad = Convert.ToInt32(txtCantidadAgregar.Text);
                    double precio = Convert.ToDouble(txtPrecioAgregar.Text);

                    foreach (DataGridViewRow fila in dataGridView.Rows)
                    {
                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == ID)
                        {
                            if ((Convert.ToInt32(fila.Cells[2].Value) + Convert.ToInt32(txtCantidadAgregar.Text)) > StockProducto)
                            {
                                MessageBox.Show("Cantidad no disponible");
                                return;
                            }

                            fila.Cells[2].Value = Convert.ToInt32(fila.Cells[2].Value) + Convert.ToInt32(txtCantidadAgregar.Text); // Agregamos la cantidad
                            fila.Cells[4].Value = Convert.ToInt32(fila.Cells[2].Value) * Convert.ToInt32(fila.Cells[3].Value);
                            existe = true;
                            break;
                        }
                    }
                    if (!existe)
                    {
                        dataGridView.Rows.Add(txtIdProducto.Text, lblDescripcionProducto.Text, cantidad, precio, cantidad * precio);
                    }
                }
            }
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            // Crear una nueva tabla DataTable
            DataTable tabla = new DataTable();

            if (comboBoxTipoPago.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de pago");
            }
            else
            {
                // Verificar si la tabla está vacía
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros");
                }
                else
                {
                    // Agregar columnas a la tabla basadas en las columnas del DataGridView
                    foreach (DataGridViewColumn dgvColumn in dataGridView.Columns)
                    {
                        tabla.Columns.Add(dgvColumn.HeaderText, typeof(string));
                    }

                    // Agregar filas a la tabla basadas en las filas del DataGridView
                    foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                    {
                        DataRow row = tabla.NewRow();
                        foreach (DataGridViewCell cell in dgvRow.Cells)
                        {
                            // Si la celda no está vacía, agregue su valor a la fila
                            if (cell.Value != null)
                            {
                                row[cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        tabla.Rows.Add(row);
                    }

                    switch (comboBoxTipoPago.Text)
                    {
                        case "Efectivo":
                            this.TipoPago = 1;
                            break;
                        case "Tarjeta de Crédito":
                            this.TipoPago = 2;
                            break;
                        case "Transferencia Bancaria":
                            this.TipoPago = 3;
                            break;
                        case "Billetera Electrónica":
                            this.TipoPago = 4;
                            break;
                    }
                    id_cliente = Convert.ToInt32(txtIdCliente.Text);
                    this.tabla = tabla;
                    this.TipoPagoText = comboBoxTipoPago.Text;

                    Comprobante formulario = new Comprobante(this, Login);
                    formulario.Show();
                }
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control como retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control como retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCantidadAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control como retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            groupBoxPedidoPedido.Enabled = false;
            txtCantidadAgregar.Text = "";
            txtPrecioAgregar.Text = "";
        }

        private void comboBoxTipoPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            FormQR formulario = new FormQR();
            formulario.Show();
        }

        private void comboBoxTipoPago_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoPago.Text == "Billetera Electrónica")
            {
                btnQR.Visible = true;
            }
            else
            {
                btnQR.Visible = false;
            }
        }
    }
}
