using System;
using System.Collections;
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
    public partial class Clientes : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        public Clientes()
        {
            InitializeComponent();
            cargar_tabla();
        }

        private void cargar_tabla()
        {
            dataGridView1.DataSource = conexion.CargarTabla("Clientes");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAceptarA_Click(object sender, EventArgs e)
        {
            conexion.AgregarNuevoCliente(txtDniA.Text, txtDireccionA.Text, txtTelefonoA.Text, txtCorreoA.Text);
            cargar_tabla();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            ArrayList cliente = conexion.ObtenerClientePorId(Convert.ToInt32(txtIDM.Text)); // Pasar el ID del cliente que deseas obtener

            if (cliente != null)
            {
                groupBoxdatosM.Enabled = true;
                txtDniM.Text = Convert.ToString(cliente[0]);
                txtDireccionM.Text = Convert.ToString(cliente[1]);
                txtTelefonoM.Text = Convert.ToString(cliente[2]);
                txtCorreoM.Text = Convert.ToString(cliente[3]);
            }
            else
            {
                groupBoxdatosM.Enabled = false;
                txtDniM.Text = "";
                txtDireccionM.Text = "";
                txtTelefonoM.Text = "";
                txtCorreoM.Text = "";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            groupBoxAgregarCliente.Visible = true;
            groupBoxModificar.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.ModificarCliente(Convert.ToInt32(txtIDM.Text), txtDniM.Text, txtDireccionM.Text, txtTelefonoM.Text, txtCorreoM.Text);
            cargar_tabla();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            groupBoxModificar.Visible = true;
            groupBoxAgregarCliente.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            groupBoxEliminar.Visible = true;
            groupBoxAgregarCliente.Visible = false;
            groupBoxModificar.Visible = false;
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            conexion.EliminarCliente(Convert.ToInt32(txtIDE.Text));
            cargar_tabla();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
