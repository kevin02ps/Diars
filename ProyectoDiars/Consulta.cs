using DevExpress.XtraCharts;
using InversionesHermanos.Conexion;
using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection("Server=bljedez49bwzhuwfxsb0-mysql.services.clever-cloud.com;Port=3306;Database=bljedez49bwzhuwfxsb0;Uid=utmmn1g1jgy0kewg;Pwd=1DRUhKmXabIu9u3K83aI;");

        public Consulta()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Datos en arreglos simples
            (string[] nombres, decimal[] cantidades) = ObtenerNombresYCantidadPorProducto();


            // Crear una serie y agregarla al ChartControl
            Series serie = new Series("Precios de Productos", ViewType.Bar);
            for (int i = 0; i < nombres.Length; i++)
            {
                serie.Points.Add(new SeriesPoint(nombres[i], cantidades[i]));
            }

            // Agregar la serie al ChartControl
            chartControl1.Series.Add(serie);

            // Personalizar la apariencia del gráfico
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;
            if (diagram != null)
            {
                diagram.AxisX.Title.Text = "Nombre del Producto";
                diagram.AxisY.Title.Text = "Precio";
                diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            }

            // Mostrar etiquetas de los valores
            serie.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            // Ocultar la leyenda
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

        public (string[] nombres, decimal[] cantidades) ObtenerNombresYCantidadPorProducto()
        {
            string[] nombres = new string[0];
            decimal[] cantidades = new decimal[0];

            try
            {
                connection.Open();
                // Consulta para obtener la suma de CANTIDAD para cada Id_Producto
                string sql = "SELECT P.Nombre, SUM(DP.CANTIDAD) AS total_cantidad " +
                             "FROM DetalleDePedidos DP " +
                             "INNER JOIN Producto P ON P.Id_Producto = DP.Id_Producto " +
                             "GROUP BY P.Id_Producto";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> nombresList = new List<string>();
                        List<decimal> cantidadesList = new List<decimal>();

                        while (reader.Read())
                        {
                            string nombre = reader.GetString("Nombre");
                            decimal totalCantidad = reader.GetDecimal("total_cantidad");
                            nombresList.Add(nombre);
                            cantidadesList.Add(totalCantidad);
                        }

                        nombres = nombresList.ToArray();
                        cantidades = cantidadesList.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener nombres y cantidades por producto: {ex.Message}");
            }

            return (nombres, cantidades);
        }
    }
}
