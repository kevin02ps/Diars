using InversionesHermanos.Conexion;
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
    public partial class Consulta : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        public Consulta()
        {
            InitializeComponent();
        }

        private void cargar_tabla()
        {
            dataGridViewPedidoC.DataSource = conexion.CargarTabla("Pedidos");
            dataGridViewPedidoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void btnBuscarCP_Click(object sender, EventArgs e)
        {
            dataGridViewDetallePedidoC.DataSource = conexion.ObtenerDetallePedido(Convert.ToInt32(txtIdPedidoC.Text));
            dataGridViewDetallePedidoC.Columns[0].Width = 90;
            dataGridViewDetallePedidoC.Columns[1].Width = 400;
            dataGridViewDetallePedidoC.Columns[2].Width = 90;
            dataGridViewDetallePedidoC.Columns[3].Width = 90;
            dataGridViewDetallePedidoC.Columns[4].Width = 90;

        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            cargar_tabla();
        }
    }
}
