using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using RestSharp;
using Humanizer;
using static System.Windows.Forms.Design.AxImporter;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;


namespace InversionesHermanos
{
    public partial class Comprobante : Form
    {
        Conexion.Conexion conexion = new Conexion.Conexion();

        ApiDni_Ruc ApisPeru = new ApiDni_Ruc();

        double MontoTotal { get; set; }
        int id_pedido { get; set; }
        private Point _mouseStartPoint;
        int alto {  get; set; }
        string NombreCliente;
        int XPDF = 500;
        int YPDF = 300;

        private Pedidos pedido;
        private Login Login;
        public Comprobante(Pedidos pedido, Login login)
        {
            InitializeComponent();
            this.pedido = pedido;
            this.Login = login;
            CargarDatos();
        }

        private string consultarClientePorDni(string dni)
        {
            try
            {
                if (dni.Length == 11)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    lblRuc.Text = "Ruc: " + dni;
                    lblFoB.Text = "FACTURA";
                    lblNumeroFactura.Text = "Factura: ";
                    NombreCliente = respuesta.razonSocial.ToString();
                    return respuesta.razonSocial.ToString();
                }
                else if (dni.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    lblRuc.Text = "Dni: " + dni;
                    lblFoB.Text = "BOLETA";
                    lblNumeroFactura.Text = "Boleta: ";
                    NombreCliente = respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                    return respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                }
                return null;
            }
            catch
            {
                return dni;
            }           
        }

        public void CargarDatos( )
        {
            ArrayList cliente = conexion.ObtenerClientePorId(pedido.id_cliente);
            lblCliente.Text = "Cliente:  " + consultarClientePorDni(Convert.ToString(cliente[0]));
            lblFecha.Text = "Fecha: " + DateTime.Today.ToString("dddd dd 'de' MMMM 'del' yyyy");
            lblTipoPago.Text = "Tipo de pago: " + pedido.TipoPagoText;
            this.alto = 270;


            foreach (DataRow fila in pedido.tabla.Rows)
            {
                // Obtener los datos de cada fila
                string cantidad = fila[2].ToString();
                string producto = fila[1].ToString();
                string precio = fila[3].ToString();
                string precioT = fila[4].ToString();
                
                // Crear Labels para mostrar los datos
                Label labelCantidad = new Label();
                labelCantidad.Text = cantidad;
                labelCantidad.AutoSize = true; // Ajustar automáticamente el tamaño
                labelCantidad.Location = new System.Drawing.Point(65, this.alto); // Posición en el formulario
                this.Controls.Add(labelCantidad);
        
                Label labelProducto = new Label();
                labelProducto.Text =  producto;
                labelProducto.AutoSize = true; // Ajustar automáticamente el tamaño
                labelProducto.Location = new System.Drawing.Point(195, this.alto); // Posición en el formulario
                this.Controls.Add(labelProducto);

                Label labelPrecio = new Label();
                labelPrecio.Text = precio;
                labelPrecio.AutoSize = true; // Ajustar automáticamente el tamaño
                labelPrecio.Location = new System.Drawing.Point(495, alto); // Posición en el formulario
                this.Controls.Add(labelPrecio);

                Label labelPrecioT = new Label();
                labelPrecioT.Text =  precioT;
                labelPrecioT.AutoSize = true; // Ajustar automáticamente el tamaño
                labelPrecioT.Location = new System.Drawing.Point(625, this.alto); // Posición en el formulario              
                this.Controls.Add(labelPrecioT);

                this.alto += 20;
                this.YPDF += 20;

                lblMontoTotal.Location = new System.Drawing.Point(585, this.alto + 20);
                this.Size = new System.Drawing.Size(750, 130 + this.alto);
            }
            // Calcular la suma de la columna "MiColumna" usando LINQ
            foreach (DataRow row in pedido.tabla.Rows)
            {
                this.MontoTotal += Convert.ToInt32(row[4]);
            }
            lblMontoTotal.Text += " " + MontoTotal;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToString("yyyy-MM-dd");

            //Agregar Pedido
            this.id_pedido =  conexion.AgregarNuevoPedido(pedido.id_cliente, fecha, Login.id_empleado, this.MontoTotal, pedido.TipoPago);
            conexion.InsertarBoleta(fecha, true, this.id_pedido);

            //Agregar DetallePedido
            foreach (DataRow fila in pedido.tabla.Rows)
            {
                int idProducto = Convert.ToInt32(fila[0]);
                int cantidad = Convert.ToInt32(fila[02]);
                int precio = Convert.ToInt32(fila[3]);
                int precioT = Convert.ToInt32(fila[4]);
                conexion.AgregarNuevoDetallePedido(this.id_pedido, idProducto, cantidad, precio, precio * cantidad);
                conexion.RetirarProductos(idProducto, cantidad);
            }
            lblNumeroFactura.Text += " 0000" + this.id_pedido;

            buttonConfirmar.Visible = false;
            btnCerrar.Visible = false;
            try
            {
                ObtenerDatosComprobanteSunat();
                ObtenerPdf();
                MessageBox.Show("Datos subidos y guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            btnCerrar.Visible = true;
        }

        public void ObtenerPdf()
        {               
            // Crear un bitmap con el tamaño de la ventana del formulario
            Bitmap screenshot = new Bitmap(this.Width, this.Height);

            // Capturar el contenido de la ventana del formulario
            this.DrawToBitmap(screenshot, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

            // Ruta donde se guardará el archivo PDF
            string ruta = "";
            if (Configuracion.UbiComprobante != null)
            {
                string ubi = Configuracion.UbiComprobante.Replace('\\', '/');
                ruta = ubi + "/Comprobante" + this.id_pedido + ".pdf";
            }
            else
            {
                ruta = "C:/Comprobante" + this.id_pedido + ".pdf";
            }

            // Crear un nuevo documento PDF
            Document doc = new Document(new iTextSharp.text.Rectangle(XPDF, YPDF));

            try
            {
                PdfWriter.GetInstance(doc, new System.IO.FileStream(ruta, System.IO.FileMode.Create));
                doc.Open();

                // Convertir el objeto Bitmap a un objeto iTextSharp.text.Image
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(screenshot, System.Drawing.Imaging.ImageFormat.Bmp);

                // Escalar la imagen para que se ajuste al tamaño del documento
                img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);

                // Centrar la imagen en el documento
                img.Alignment = iTextSharp.text.Image.ALIGN_CENTER | iTextSharp.text.Image.ALIGN_MIDDLE;


                // Agregar la imagen al documento
                doc.Add(img);

                Console.WriteLine("¡La conversión se ha completado con éxito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir la imagen a PDF: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close();
                }
            }
        }

        private void Comprobante_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Pen con el color y el grosor deseado
            Pen pen = new Pen(Color.DarkGray, 1);

            // Dibujar una línea desde (x1, y1) a (x2, y2)
            e.Graphics.DrawLine(pen, 55, 170, 700, 170);
            e.Graphics.DrawLine(pen, 55, 230, 700, 230);
            e.Graphics.DrawLine(pen, 55, 265, 700, 265);
            e.Graphics.DrawLine(pen, 55, 10 + this.alto, 740, 10 + this.alto);

            // Liberar los recursos del objeto Pen
            pen.Dispose();
        }

        private void Comprobante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseStartPoint = e.Location;
            }
        }

        private void Comprobante_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X - _mouseStartPoint.X + e.X, Location.Y - _mouseStartPoint.Y + e.Y);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ObtenerDatosComprobanteSunat()
        {
            if (Login.dni.Length == 8)
            {
                ArrayList Lista = new ArrayList();
                double igv = 0.18;
                Lista.Add("20610265023-03-B001-" + id_pedido.ToString("D8")); // Lista[0]
                Lista.Add("B001-" + id_pedido.ToString("D8")); // Lista[1]
                Lista.Add(DateTime.Now.ToString("yyyy-MM-dd")); // Lista[2]
                Lista.Add("0101"); // Lista[3]
                Lista.Add(ConvertirNumeroATexto(MontoTotal)); // Lista[4]
                Lista.Add(Login.dni); // Lista[5]
                Lista.Add(NombreCliente); // Lista[6]
                Lista.Add("Trujillo"); // Lista[7]
                Lista.Add(MontoTotal * igv); // Lista[8] 
                Lista.Add(Lista.Add(MontoTotal * igv + MontoTotal)); // Lista[9]
                Lista.Add(MontoTotal); // Lista[10]
                Lista.Add(pedido.tabla.Rows.Count.ToString()); // Lista[11]
                                                               // Crear una nueva tabla DataTable
                DataTable dt = new DataTable();

                // Definir las columnas de la tabla DataTable
                dt.Columns.Add("IdProducto", typeof(int));
                dt.Columns.Add("CantidadP", typeof(int));
                dt.Columns.Add("OperacionGravadaP", typeof(double));
                dt.Columns.Add("PriceAmountP", typeof(double));
                dt.Columns.Add("igvP", typeof(double));
                dt.Columns.Add("NombreProducto", typeof(string));
                dt.Columns.Add("Precio", typeof(double));

                // Iterar a través de cada fila en la tabla 'pedido' y agregar a 'dt'
                foreach (DataRow fila in pedido.tabla.Rows)
                {
                    // Crear una nueva fila para la tabla 'dt'
                    DataRow nuevaFila = dt.NewRow();

                    // Asignar los valores de la fila actual de 'pedido' a la nueva fila de 'dt'
                    nuevaFila["IdProducto"] = fila[0]; // IdProducto
                    nuevaFila["CantidadP"] = fila[2]; // CantidadP
                    nuevaFila["OperacionGravadaP"] = Convert.ToDouble(fila[4]); // OperacionGravadaP
                    nuevaFila["PriceAmountP"] = Convert.ToDouble(fila[3]) * igv + Convert.ToDouble(fila[3]); // PriceAmountP
                    nuevaFila["igvP"] = Convert.ToDouble(fila[4]) * igv; // igvP
                    nuevaFila["NombreProducto"] = fila[1]; // NombreProducto
                    nuevaFila["Precio"] = fila[3]; // Precio

                    // Agregar la nueva fila a la tabla 'dt'
                    dt.Rows.Add(nuevaFila);
                }
                
                SubirSunatBoleta(Lista, dt);
            }
        }

        public  async Task SubirSunatBoleta(ArrayList Lista, DataTable tablaItem)
        {
            try
            {
                string filename = Convert.ToString(Lista[0]);
                string id = Convert.ToString(Lista[1]);
                string fecha = Convert.ToString(Lista[2]);
                string TypeCode_ListID = Convert.ToString(Lista[3]);
                string NoteText = Convert.ToString(Lista[4]);
                string DniCliente = Convert.ToString(Lista[5]);
                string NombreCliente = Convert.ToString(Lista[6]);
                string DireccionCliente = Convert.ToString(Lista[7]);
                string IgvT = Convert.ToString(Lista[8]);
                string OperacionGravadaT = Convert.ToString(Lista[9]);
                string ImporteTotalT = Convert.ToString(MontoTotal);

                int CantidadItems = Convert.ToInt32(Lista[11]);

                var client = new RestClient("https://back.apisunat.com");

                var request = new RestRequest("/personas/v1/sendBill", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                ArrayList listaitem = new ArrayList();
                var jsonString = @"";
                int i = 0;
                foreach (DataRow fila in tablaItem.Rows)
                {
                    foreach (DataColumn columna in tablaItem.Columns)
                    {                        
                        // Acceder al valor de la celda actual
                        object valor = fila[columna];
                        string elementoString = Convert.ToString(valor);

                        listaitem.Add(elementoString);
                    }
                    i++;
                    jsonString += @"
                {
                    ""cbc:ID"": {
                        ""_text"": """ + i + @"""
                    },
                    ""cbc:InvoicedQuantity"": {
                        ""_attributes"": {
                            ""unitCode"": ""NIU""
                        },
                        ""_text"": """ + listaitem[1] + @"""
                    },
                    ""cbc:LineExtensionAmount"": {
                        ""_attributes"": {
                            ""currencyID"": ""PEN""
                        },
                        ""_text"": """ + listaitem[2] + @"""
                    },
                    ""cac:PricingReference"": {
                        ""cac:AlternativeConditionPrice"": {
                            ""cbc:PriceAmount"": {
                                ""_attributes"": {
                                    ""currencyID"": ""PEN""
                                },
                                ""_text"": """ + listaitem[3] + @"""
                            },
                            ""cbc:PriceTypeCode"": {
                                ""_text"": ""01""
                            }
                        }
                    },
                    ""cac:TaxTotal"": {
                        ""cbc:TaxAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + listaitem[4] + @"""  
                        },
                        ""cac:TaxSubtotal"": [
                            {
                                ""cbc:TaxableAmount"": {
                                    ""_attributes"": {
                                        ""currencyID"": ""PEN""
                                    },
                                    ""_text"": """ + listaitem[2] + @"""
                                },
                                ""cbc:TaxAmount"": {
                                    ""_attributes"": {
                                        ""currencyID"": ""PEN""
                                    },
                                    ""_text"": """ + listaitem[4] + @""" 
                                },
                                ""cac:TaxCategory"": {
                                    ""cbc:Percent"": {
                                        ""_text"": 18
                                    },
                                    ""cbc:TaxExemptionReasonCode"": {
                                        ""_text"": ""10""
                                    },
                                    ""cac:TaxScheme"": {
                                        ""cbc:ID"": {
                                            ""_text"": ""1000""
                                        },
                                        ""cbc:Name"": {
                                            ""_text"": ""IGV""
                                        },
                                        ""cbc:TaxTypeCode"": {
                                            ""_text"": ""VAT""
                                        }
                                    }
                                }
                            }
                        ]
                    },
                    ""cac:Item"": {
                        ""cbc:Description"": {
                            ""_text"": """ + listaitem[5] + @"""
                        }
                    },
                    ""cac:Price"": {
                        ""cbc:PriceAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + listaitem[6] + @"""
                        }
                    }
                }";

                    // Coma para separar elementos en el arreglo JSON, excepto el último elemento
                    if (fila != tablaItem.Rows[tablaItem.Rows.Count - 1])
                    {
                        jsonString += ",";
                    }

                    listaitem.Clear();
                }

                var body = @"{
                ""personaId"": ""6678573bbc2b5f0015d403e6"",
                ""personaToken"": ""DEV_3QFwGACMqADtfEOmjPlLErYP1LCFKX14nP24ELudaBlVkBAbQ6UGns8FlZxEOsBX"",
                ""fileName"": """ + filename + @""",
                ""documentBody"": {
                    ""cbc:UBLVersionID"": {
                        ""_text"": ""2.1""
                    },
                    ""cbc:CustomizationID"": {
                        ""_text"": ""2.0""
                    },
                    ""cbc:ID"": {
                        ""_text"": """ + id + @"""
                    },
                    ""cbc:IssueDate"": {
                        ""_text"": """ + fecha + @"""
                    },
                    ""cbc:InvoiceTypeCode"": {
                        ""_attributes"": {
                            ""listID"": ""0101""
                        },
                        ""_text"": ""03""
                    },
                    ""cbc:DocumentCurrencyCode"": {
                        ""_text"": ""PEN""
                    },
                    ""cac:AccountingSupplierParty"": {
                        ""cac:Party"": {
                            ""cac:PartyIdentification"": {
                                ""cbc:ID"": {
                                    ""_attributes"": {
                                        ""schemeID"": ""6""
                                    },
                                    ""_text"": ""20610265023""
                                }
                            },
                            ""cac:PartyLegalEntity"": {
                                ""cbc:RegistrationName"": {
                                    ""_text"": ""INVERSIONES HERMANOS M & R S.A.C.""
                                },
                                ""cac:RegistrationAddress"": {
                                    ""cbc:AddressTypeCode"": {
                                        ""_text"": ""0000""
                                    },
                                    ""cac:AddressLine"": {
                                        ""cbc:Line"": {
                                            ""_text"": ""CAL. LAS CASUARINAS MZ. A LT. 11 URB. PALMERAS RINCONADA TRUJILLO TRUJILLO LA LIBERTAD""
                                        }
                                    }
                                }
                            }
                        }
                    },
                    ""cac:AccountingCustomerParty"": {
                        ""cac:Party"": {
                            ""cac:PartyIdentification"": {
                                ""cbc:ID"": {
                                    ""_attributes"": {
                                        ""schemeID"": ""1""
                                    },
                                    ""_text"": """ + DniCliente + @"""
                                }
                            },
                            ""cac:PartyLegalEntity"": {
                                ""cbc:RegistrationName"": {
                                    ""_text"": """ + NombreCliente + @"""
                                },
                                ""cac:RegistrationAddress"": {
                                    ""cac:AddressLine"": {
                                        ""cbc:Line"": {
                                            ""_text"": """ + DireccionCliente + @"""
                                        }
                                    }
                                }
                            }
                        }
                    },
                    ""cac:TaxTotal"": {
                        ""cbc:TaxAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + IgvT + @"""
                        },
                        ""cac:TaxSubtotal"": [
                            {
                                ""cbc:TaxableAmount"": {
                                    ""_attributes"": {
                                        ""currencyID"": ""PEN""
                                    },
                                    ""_text"": """ + ImporteTotalT + @"""
                                },
                                ""cbc:TaxAmount"": {
                                    ""_attributes"": {
                                        ""currencyID"": ""PEN""
                                    },
                                    ""_text"": """ + IgvT + @"""
                                },
                                ""cac:TaxCategory"": {
                                    ""cac:TaxScheme"": {
                                        ""cbc:ID"": {
                                            ""_text"": ""1000""
                                        },
                                        ""cbc:Name"": {
                                            ""_text"": ""IGV""
                                        },
                                        ""cbc:TaxTypeCode"": {
                                            ""_text"": ""VAT""
                                        }
                                    }
                                }
                            }
                        ]
                    },
                    ""cac:LegalMonetaryTotal"": {
                        ""cbc:LineExtensionAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + ImporteTotalT + @"""
                        },
                        ""cbc:TaxInclusiveAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + OperacionGravadaT + @"""
                        },
                        ""cbc:PayableAmount"": {
                            ""_attributes"": {
                                ""currencyID"": ""PEN""
                            },
                            ""_text"": """ + OperacionGravadaT + @"""
                        }
                    },
                    ""cac:InvoiceLine"": [
                        " + jsonString + @"
                    ]
                }
            }";

                // Ruta donde se guardará el archivo PDF
                string rutaArchivo = "";
                if (Configuracion.UbiComprobante != null)
                {
                    string ubi = Configuracion.UbiComprobante.Replace('\\', '/');
                    rutaArchivo = ubi + "/XML" + filename + ".txt";
                }
                else
                {
                    rutaArchivo = "C:/XML" + filename + ".txt";
                }
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = await client.ExecuteAsync(request);
                string jsonS = response.Content;
                JObject jsonObject = JObject.Parse(jsonS);
                string documentId = (string)jsonObject["documentId"];
                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        writer.WriteLine(response.Content);
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show($"Error al escribir en el archivo: {e.Message}");
                }
                string url = "https://apisunat.com/api/documents/" + documentId + "/getPDF/ticket58mm/" + filename + ".pdf";

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    Console.WriteLine("La URL se ha abierto en el navegador predeterminado.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al abrir la URL: " + e.Message);
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error: ", e.Message);
            }

        }
    
        public static string ConvertirNumeroATexto(double numero)
        {
            // Convertimos el número a decimal para evitar problemas de precisión con double
            decimal numeroDecimal = (decimal)numero;

            // Separamos la parte entera y la parte decimal
            long parteEntera = (long)numeroDecimal;
            int parteDecimal = (int)((numeroDecimal - parteEntera) * 100);

            // Convertimos la parte entera a texto
            string textoParteEntera = parteEntera.ToWords(new System.Globalization.CultureInfo("es")).ToUpper();

            // Formateamos la parte decimal
            string textoParteDecimal = parteDecimal.ToString("00");

            // Componemos el resultado final
            return $"{textoParteEntera} CON {textoParteDecimal}/100 SOLES";
        }

    }
}
