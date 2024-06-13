using InversionesHermanos;
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
    public partial class Producto : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        public Producto()
        {
            InitializeComponent();
            cargar_tabla();
        }

        private void cargar_tabla()
        {
            dataGridView1.DataSource = conexion.CargarTabla("Producto");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProducto.Visible = true;
            groupBoxModificar.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            groupBoxModificar.Visible = true;
            groupBoxAgregarProducto.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            groupBoxEliminar.Visible = true;
            groupBoxAgregarProducto.Visible = false;
            groupBoxModificar.Visible = false;
        }

        private void btnEliminarE_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.EliminarProducto(Convert.ToInt32(txtIDE.Text));
                cargar_tabla();
            }
            catch
            {
                MessageBox.Show("Ingrese bien los datos");
            }
        }

        private void btnBuscarM_Click_1(object sender, EventArgs e)
        {
            ArrayList producto = conexion.ObtenerProductoPorId(Convert.ToInt32(txtIDM.Text)); // Pasar el ID del Producto que deseas obtener

            if (producto != null)
            {
                groupBoxdatosM.Enabled = true;
                txtNombreM.Text = Convert.ToString(producto[0]);
                txtDescripcionM.Text = Convert.ToString(producto[1]);
                txtPrecioM.Text = Convert.ToString(producto[2]);
                txtCantStockM.Text = Convert.ToString(producto[3]);
            }
            else
            {
                groupBoxdatosM.Enabled = false;
                txtNombreM.Text = "";
                txtDescripcionM.Text = "";
                txtPrecioM.Text = "";
                txtCantStockM.Text = "";
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.ModificarProducto(Convert.ToInt32(txtIDM.Text), txtNombreM.Text, txtDescripcionM.Text, Convert.ToInt32(txtPrecioM.Text), Convert.ToInt32(txtCantStockM.Text));
                cargar_tabla();
            }  
            catch
            {
                MessageBox.Show("Ingrese bien los datos");
            }
        }

        private void btnAceptarA_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.AgregarNuevoProducto(txtNombreA.Text, txtDescripcionA.Text, Convert.ToInt32(txtPrecioA.Text), Convert.ToInt32(txtCantStockA.Text), Convert.ToInt32(txtIdProveedorA.Text));
                cargar_tabla();
            }  
            catch
            {
                MessageBox.Show("Ingrese bien los datos");
            }
        }
    }
}
