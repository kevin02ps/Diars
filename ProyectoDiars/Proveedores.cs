using InversionesHermanos.Conexion;
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
    public partial class Proveedores : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        public Proveedores()
        {
            InitializeComponent();
            cargar_tabla();
        }

        private void cargar_tabla()
        {
            dataGridView1.DataSource = conexion.CargarTabla("Proveedores");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            groupBoxAgregar.Visible = true;
            groupBoxModificar.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnModificarProducto_Click_1(object sender, EventArgs e)
        {
            groupBoxModificar.Visible = true;
            groupBoxAgregar.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            groupBoxEliminar.Visible = true;
            groupBoxAgregar.Visible = false;
            groupBoxModificar.Visible = false;
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            ArrayList proveedor = conexion.ObtenerProveedorPorId(Convert.ToInt32(txtIDM.Text)); // Pasar el ID del Producto que deseas obtener

            if (proveedor != null)
            {
                groupBoxdatosM.Enabled = true;
                txtRazonSocialM.Text = Convert.ToString(proveedor[0]);
                txtRucM.Text = Convert.ToString(proveedor[1]);
                txtContactoM.Text = Convert.ToString(proveedor[2]);
                txtDireccionM.Text = Convert.ToString(proveedor[3]);
            }
            else
            {
                groupBoxdatosM.Enabled = false;
                txtRazonSocialM.Text = "";
                txtRucM.Text = "";
                txtContactoM.Text = "";
                txtDireccionM.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.ModificarProveedor(Convert.ToInt32(txtIDM.Text), txtRazonSocialM.Text, txtRucM.Text, txtContactoM.Text, txtDireccionM.Text);
            cargar_tabla();
        }

        private void btnAceptarA_Click(object sender, EventArgs e)
        {
            conexion.AgregarNuevoProveedor(txtRazonSocialA.Text, txtRucA.Text, txtContactoA.Text, txtDireccionA.Text);
            cargar_tabla();
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            conexion.EliminarProveedor(Convert.ToInt32(txtIDE.Text));
            cargar_tabla();
        }
    }
}
