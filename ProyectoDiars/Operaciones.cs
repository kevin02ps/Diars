using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversionesHermanos
{
    public partial class Operaciones : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();
        ApiDni_Ruc ApisPeru = new ApiDni_Ruc();

        private Login Login;
        public Operaciones(Login login)
        {
            InitializeComponent();  
            this.Login = login;
            if(Login.cargo == "admin")
            {
                lblEmpleado.Text = Login.cargo;
            }
            else
            {
                lblEmpleado.Text = Login.cargo + ", " + consultarClientePorDni(Convert.ToString(Login.dni));
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
            Clientes productos = new Clientes();
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
    }
}
