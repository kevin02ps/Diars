using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGauges.Core.Customization;
using InversionesHermanos.Conexion;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            comboBoxGrafico1.Text = "Ventas totales";
            comboBox1.Text = "Diario";
            CargarDatos1(1);
            CargarDatos2();
        }
        private void CargarDatos1(int llamado)
        {
            string[] x = new string[0];
            decimal[] y = new decimal[0];
            // Datos en arreglos simples
            switch (llamado)
            {
                case 1:
                    (x, y) = ObtenerNombresYCantidadPorProducto();
                    break;
                case 2:
                    (x, y) = ObtenerMontosTotalesEnRangoFechas();
                    break;
            }


            // Crear una serie y agregarla al ChartControl
            Series serie = new Series("Productos", ViewType.Bar);
            for (int i = 0; i < x.Length; i++)
            {
                serie.Points.Add(new SeriesPoint(x[i], y[i]));

            }
            // Agregar la serie al ChartControl
            chartControl1.Series.Add(serie);

            // Mostrar etiquetas de los valores
            serie.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            // Ocultar la leyenda
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }
        public (string[] nombres, decimal[] cantidades) ObtenerNombresYCantidadPorProducto()
        {
            List<string> nombresList = new List<string>();
            List<decimal> cantidadesList = new List<decimal>();

            try
            {
                connection.Open();
                string sql = "";
                // Consulta para obtener la suma de CANTIDAD para cada Id_Producto
                switch (comboBox1.Text)
                {
                    case "Mensual":
                        sql = "SELECT P.Nombre AS x, SUM(DP.Cantidad) AS y " +
                              "FROM DetalleDePedidos DP " +
                              "INNER JOIN Producto P ON P.Id_Producto = DP.Id_Producto " +
                              "INNER JOIN Pedidos Pe ON DP.Id_Pedido = Pe.Id_Pedido " +
                              "WHERE Pe.Fecha >= @inicio AND Pe.Fecha <= @fin " +
                              "GROUP BY P.Nombre " +
                              "ORDER BY P.Nombre;";
                        break;
                    case "Anual":
                        sql = "SELECT P.Nombre AS x, SUM(DP.Cantidad) AS y " +
                              "FROM DetalleDePedidos DP " +
                              "INNER JOIN Producto P ON P.Id_Producto = DP.Id_Producto " +
                              "INNER JOIN Pedidos Pe ON DP.Id_Pedido = Pe.Id_Pedido " +
                              "WHERE Pe.Fecha >= @inicio AND Pe.Fecha <= @fin " +
                              "GROUP BY P.Nombre " +
                              "ORDER BY P.Nombre;";
                        break;
                    case "Diario":
                        sql = "SELECT P.Nombre AS x, SUM(DP.Cantidad) AS y " +
                              "FROM DetalleDePedidos DP " +
                              "INNER JOIN Producto P ON P.Id_Producto = DP.Id_Producto " +
                              "INNER JOIN Pedidos Pe ON DP.Id_Pedido = Pe.Id_Pedido " +
                              "WHERE Pe.Fecha >= @inicio AND Pe.Fecha <= @fin " +
                              "GROUP BY P.Nombre " +
                              "ORDER BY P.Nombre;";
                        break;
                    default:
                        throw new ArgumentException("Opción de consulta no válida.");
                }

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@inicio", dateTimePicker1.Value.Date);
                    command.Parameters.AddWithValue("@fin", dateTimePicker2.Value.Date);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString("x");
                            decimal cantidad = reader.GetDecimal("y");
                            nombresList.Add(nombre);
                            cantidadesList.Add(cantidad);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener nombres y cantidades por producto: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            // Convertir listas a arreglos y retornar
            string[] nombres = nombresList.ToArray();
            decimal[] cantidades = cantidadesList.ToArray();
            return (nombres, cantidades);
        }
        public (string[] fechas, decimal[] montosTotales) ObtenerMontosTotalesEnRangoFechas()
        {
            List<string> fechasList = new List<string>();
            List<decimal> montosTotalesList = new List<decimal>();

            try
            {
                connection.Open();
                string sql = "";
                // Consulta para obtener la suma de MontoTotal en el rango de fechas
                switch (comboBox1.Text)
                {
                    case "Mensual":
                        sql = "SELECT DATE_FORMAT(Fecha, '%Y-%m') AS x, SUM(MontoTotal) AS y " +
                              "FROM Pedidos " +
                              "WHERE Fecha >= @inicio AND Fecha <= @fin " +
                              "GROUP BY DATE_FORMAT(Fecha, '%Y-%m') " +
                              "ORDER BY x;";
                        break;
                    case "Anual":
                        sql = "SELECT YEAR(Fecha) AS x, SUM(MontoTotal) AS y " +
                              "FROM Pedidos " +
                              "WHERE Fecha >= @inicio AND Fecha <= @fin " +
                              "GROUP BY YEAR(Fecha) " +
                              "ORDER BY x;";
                        break;
                    case "Diario":
                        sql = "SELECT Fecha AS x, SUM(MontoTotal) AS y " +
                              "FROM Pedidos " +
                              "WHERE Fecha >= @inicio AND Fecha <= @fin " +
                              "GROUP BY x " +
                              "ORDER BY x;";
                        break;
                    default:
                        throw new ArgumentException("Opción de consulta no válida.");
                }

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@inicio", dateTimePicker1.Value.Date);
                    command.Parameters.AddWithValue("@fin", dateTimePicker2.Value.Date);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fecha;
                            if (comboBox1.Text == "Anual")
                            {
                                // En caso de consulta "Anual", leemos el año como entero y lo convertimos a string
                                int anio = reader.GetInt32("x");
                                fecha = anio.ToString();
                            }
                            else if (comboBox1.Text == "Diario")
                            {
                                // Para consulta "Diario", leemos la fecha directamente como DateTime
                                DateTime fechaDiaria = reader.GetDateTime("x");
                                fecha = fechaDiaria.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                // Para consulta "Mensual", leemos la fecha formateada como string
                                fecha = reader.GetString("x");
                            }

                            decimal montoTotal = reader.GetDecimal("y");
                            fechasList.Add(fecha);
                            montosTotalesList.Add(montoTotal);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener montos totales por fecha: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            // Convertir listas a arreglos y retornar
            string[] fechas = fechasList.ToArray();
            decimal[] montosTotales = montosTotalesList.ToArray();
            return (fechas, montosTotales);
        }

        public void CargarDatos2()
        {
            // Datos en arreglos simples
            (string[] nombres, decimal[] precios) = ObtenerTop5ProductosMasVendidos();

            // Crear una serie y agregarla al ChartControl
            Series serie = new Series("Precios de Productos", ViewType.Pie);
            for (int i = 0; i < nombres.Length; i++)
            {
                serie.Points.Add(new SeriesPoint(nombres[i], precios[i]));
            }

            // Agregar la serie al ChartControl
            chartControl2.Series.Add(serie);

            // Configurar la vista de la serie
            PieSeriesView pieView = (PieSeriesView)serie.View;

            // Opcional: Explotar el primer punto
            pieView.ExplodedPoints.Add(serie.Points[0]);
            pieView.ExplodeMode = PieExplodeMode.UsePoints;
            pieView.RuntimeExploding = true;

            // Ocultar la leyenda
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Asumiendo que chartControl1 ya está presente en tu formulario
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "Top 5 Productos mas vendidos";
            chartTitle.TextColor = Color.Blue;
            chartTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            chartTitle.Alignment = StringAlignment.Center;
            chartControl2.Titles.Add(chartTitle);

            // Configurar etiquetas para mostrar valores y porcentajes
            PieSeriesLabel seriesLabel = (PieSeriesLabel)serie.Label;
            seriesLabel.TextPattern = "{A}: {VP:P0} ({V:F2})";

            // Ajustar apariencia de la etiqueta
            seriesLabel.Position = PieSeriesLabelPosition.TwoColumns;
            seriesLabel.ResolveOverlappingMode = ResolveOverlappingMode.Default;
        }
        public (string[] nombres, decimal[] cantidades) ObtenerTop5ProductosMasVendidos()
        {
            string[] nombres = new string[0];
            decimal[] cantidades = new decimal[0];

            try
            {
                connection.Open();
                // Consulta para obtener los 5 productos más vendidos
                string sql = "SELECT P.Nombre, SUM(DP.CANTIDAD) AS total_cantidad " +
                                "FROM DetalleDePedidos DP " +
                                "INNER JOIN Producto P ON P.Id_Producto = DP.Id_Producto " +
                                "GROUP BY DP.Id_Producto " +
                                "ORDER BY total_cantidad DESC " +
                                "LIMIT 5";

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
                throw new Exception($"Error al obtener los 5 productos más vendidos: {ex.Message}");
            }
            connection.Close();
            return (nombres, cantidades);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxGrafico1.Text == "Cantidad por producto")
            {
                LimpiarChartControl(chartControl1);
                CargarDatos1(1);
            }
            else if (comboBoxGrafico1.Text == "Ventas totales")
            {
                LimpiarChartControl(chartControl1);
                CargarDatos1(2);
            }
            LimpiarChartControl(chartControl2);

            CargarDatos2();
        }
        public void LimpiarChartControl(ChartControl chartControl)
        {
            // Limpiar todas las series y puntos
            chartControl.Series.Clear();

            // Limpiar títulos
            chartControl.Titles.Clear();

            // Limpiar leyenda (opcional)
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Limpiar anotaciones (opcional)
            chartControl.Annotations.Clear();
        }
    }
}
