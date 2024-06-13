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
    public partial class Empleado : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        public Empleado()
        {
            InitializeComponent();
            cargar_tabla();
        }

        private void cargar_tabla()
        {
            dataGridView1.DataSource = conexion.CargarTabla("Empleados");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAgregarEmpleado_Click_1(object sender, EventArgs e)
        {
            groupBoxAgregarCliente.Visible = true;
            groupBoxModificar.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnModificarEmpleado_Click_1(object sender, EventArgs e)
        {
            groupBoxModificar.Visible = true;
            groupBoxAgregarCliente.Visible = false;
            groupBoxEliminar.Visible = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            groupBoxEliminar.Visible = true;
            groupBoxAgregarCliente.Visible = false;
            groupBoxModificar.Visible = false;
        }

        private void btnBuscarM_Click_1(object sender, EventArgs e)
        {
            ArrayList empleado = conexion.ObtenerEmpleadoPorId(Convert.ToInt32(txtIDM.Text)); // Pasar el ID del cliente que deseas obtener

            if (empleado != null)
            {
                groupBoxdatosM.Enabled = true;
                txtDniM.Text = Convert.ToString(empleado[0]);
                comboBoxCargoM.Text = Convert.ToString(empleado[1]);
                txtUsuarioM.Text = Convert.ToString(empleado[2]);
                txtContraseñaM.Text = Convert.ToString(empleado[3]);
            }
            else
            {
                groupBoxdatosM.Enabled = false;
                txtDniM.Text = "";
                comboBoxCargoM.Text = "";
                txtUsuarioM.Text = "";
                txtContraseñaM.Text = "";
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            conexion.ModificarEmpleado(Convert.ToInt32(txtIDM.Text), txtDniM.Text, Convert.ToString(ObtenerCargo(comboBoxCargoM.Text)), txtUsuarioM.Text, txtContraseñaM.Text);
            cargar_tabla();
        }

        private void btnAceptarA_Click_1(object sender, EventArgs e)
        {
            conexion.AgregarEmpleado(txtDniA.Text, Convert.ToString(ObtenerCargo(comboBoxCargoA.Text)), txtUsuarioA.Text, txtContraseñaA.Text);
            cargar_tabla();
        }

        private void btnEliminarE_Click_1(object sender, EventArgs e)
        {
            conexion.EliminarEmpleado(Convert.ToInt32(txtIDE.Text));
            cargar_tabla();
        }
        public int ObtenerCargo(string cargotext)
        {
            int cargo = 0;
            switch (cargotext)
            {
                case "GERENTE":
                    cargo = 1;
                    break;
                case "VENDEDOR":
                    cargo = 2;
                    break;
                case "ADMINISTRADOR":
                    cargo = 3;
                    break;
            }
            return cargo;
        }
    }
}
