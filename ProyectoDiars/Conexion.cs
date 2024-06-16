using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using static Mysqlx.Crud.Order.Types;

namespace InversionesHermanos.Conexion
{
    public class Conexion
    {
        MySqlConnection connection = new MySqlConnection("Server=bljedez49bwzhuwfxsb0-mysql.services.clever-cloud.com;Port=3306;Database=bljedez49bwzhuwfxsb0;Uid=utmmn1g1jgy0kewg;Pwd=1DRUhKmXabIu9u3K83aI;");

        //Metodo para Iniciar Sesion
        public string[] VerificarUsuario(string usuario, string contrasena)
        {
            connection.Close();
            connection.Open();
            string query = "SELECT E.Id_Empleado, E.Dni, C.TipoDeCargo, U.Id_usuario, U.Id_TipoEstado FROM Usuarios U " +
                           "INNER JOIN Empleados E ON E.id_usuario = U.id_usuario " +
                           "INNER JOIN Cargo C ON C.Id_TipoCargo = E.Id_TipoCargo " +
                           "WHERE U.Usuario = @Usuario AND U.Contraseña = @Contraseña;";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@Contraseña", contrasena);

            try
            {              
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string idEmpleado = reader["Id_Empleado"].ToString();
                        string dniEmpleado = reader["Dni"].ToString();
                        string cargoEmpleado = reader["TipoDeCargo"].ToString();
                        string Id_usuario = reader["Id_usuario"].ToString();
                        string Id_TipoEstado = reader["Id_TipoEstado"].ToString();
                        connection.Close();
                        return new string[] { idEmpleado, dniEmpleado, cargoEmpleado, Id_usuario, Id_TipoEstado };
                    }
                    else
                    {
                        connection.Close();
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener Usuario: " + ex.Message);
                connection.Close();
                return null;
            }
        }
        
        public void CambiarEstadoUsuario(int Id_usuario, int estado)
        {
            {
                connection.Open();
                try
                {
                    string query = "UPDATE Usuarios SET Id_TipoEstado = @estado WHERE Id_usuario = @Id_usuario";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Añade parámetros para evitar problemas de seguridad e inyección de SQL
                        command.Parameters.AddWithValue("@Id_usuario", Id_usuario);
                        command.Parameters.AddWithValue("@estado", estado);

                        command.ExecuteNonQuery();                     
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        public ArrayList Extraer_Usuarios()
        {

            ArrayList list = new ArrayList();

            string query = $"SELECT {"correo, contraseña"} FROM {"Usuarios"}";
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string Usuario = reader["correo"].ToString();
                    string Contra = reader["contraseña"].ToString();
                    list.Add(Usuario + Contra);
                }

                return list;
            }
        }

        public bool Agregar_Usuario(string username, string password)
        {
            string query = "INSERT INTO Usuarios(nombre_usuario, correo, rol, Contraseña) VALUES (@nombre_usuario, @correo, @rol, @Contraseña)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre_usuario", username);
                command.Parameters.AddWithValue("@correo", username);
                command.Parameters.AddWithValue("@rol", username);
                command.Parameters.AddWithValue("@Contraseña", password);

                int result = command.ExecuteNonQuery();

                // Verificar si el registro fue exitoso
                if (result < 0)
                    return false;
                else
                    return true;
            }
        }

        //Metodo para cargar tablas
        public DataTable CargarTabla(string nombretabla)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + nombretabla + "", connection))
                {
                    adapter.Fill(dataTable);
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            connection.Close();
            return dataTable;
        }

        //Opciones para Producto
        public void ModificarProducto(int id_producto, string Nombre, string Descripcion, int Precio, int CantDeStock)
        {
            connection.Open();
            try
            {
                string query = "UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, CantStock = @CantDeStock WHERE Id_Producto = @id_producto";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Añade parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@id_producto", id_producto);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@CantDeStock", CantDeStock);

                    int filasModificadas = command.ExecuteNonQuery();

                    if (filasModificadas > 0)
                    {
                        System.Windows.MessageBox.Show("Datos modificados correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró el producto con ID " + id_producto);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al modificar los datos: " + ex.Message);
            }
            connection.Close();
        }
        public void AgregarNuevoProducto(string nombre, string descripcion, int precio, int stock, int proveedor)
        {
            connection.Open();
            try
            {
                string query = "INSERT INTO Producto (Nombre, Descripcion, Precio, CantStock, Id_Proveedor) VALUES (@Nombre, @Descripcion, @Precio, @CantDeStock, @Proveedor)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@CantDeStock", stock);
                    command.Parameters.AddWithValue("@Proveedor", proveedor);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Producto agregado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se pudo agregar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
            connection.Close();
        }
        public void EliminarProducto(int id_producto)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Producto WHERE Id_Producto = @id_producto";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_producto", id_producto);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Producto eliminado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún Producto con el ID especificado.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al eliminar el Producto: " + ex.Message);
            }
            connection.Close();
        }
        public ArrayList ObtenerProductoPorId(int idproducto)
        {
            connection.Open();
            ArrayList cliente = null;

            try
            {
                string query = "SELECT Nombre, Descripcion, Precio, CantStock, Id_Proveedor " +
                               "FROM Producto WHERE Id_Producto = @idproducto";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID del cliente
                    command.Parameters.AddWithValue("@idproducto", idproducto);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ArrayList
                            {
                                reader["Nombre"],
                                reader["Descripcion"],
                                reader["Precio"],
                                reader["CantStock"],
                                reader["Id_Proveedor"]
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el Producto: " + ex.Message);
            }
            connection.Close();
            return cliente;
        }

        //Metodos para Cliente
        public void AgregarNuevoCliente(string dni, string Direccion, string Telefono, string CorreoElectronico)
        {
            connection.Open();
            try
            {
                string query = "INSERT INTO Clientes (Dni, Direccion, Telefono, CorreoElectronico) " +
                               "VALUES (@dni, @Direccion, @Telefono, @CorreoElectronico)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Nuevo cliente agregado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se pudo agregar el nuevo cliente.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el nuevo cliente: " + ex.Message);
            }

            connection.Close();
        }
        public void ModificarCliente(int clienteId, string dni, string Direccion, string Telefono, string CorreoElectronico)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Clientes SET Dni = @dni, Direccion = @Direccion, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico WHERE Id_Cliente = @ClienteId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Cliente modificado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún cliente con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
            connection.Close();
        }
        public void EliminarCliente(int clienteId)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Clientes WHERE Id_Cliente = @ClienteId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Cliente eliminado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún cliente con el ID especificado.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
            connection.Close();
        }
        public ArrayList ObtenerClientePorId(int id_cliente)
        {
            connection.Open();
            ArrayList cliente = null;

            try
            {
                string query = "SELECT Dni, Direccion, Telefono, CorreoElectronico " +
                               "FROM Clientes WHERE Id_Cliente = @Id_Cliente";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID del cliente
                    command.Parameters.AddWithValue("@Id_Cliente", id_cliente);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ArrayList
                            {
                                reader["Dni"],
                                reader["Direccion"],
                                reader["Telefono"],
                                reader["CorreoElectronico"]
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el cliente: " + ex.Message);
            }
            connection.Close();
            return cliente;
        }

        //Metodos para proveedor
        public void AgregarNuevoProveedor(string razonSocial, string ruc, string contacto, string direccion)
        {
            connection.Open();
            try
            {
                string query = "INSERT INTO Proveedores (RazonSocial, Ruc, Contacto, Direccion ) " +
                               "VALUES (@razonSocial, @ruc, @contacto, @direccion )";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@razonSocial", razonSocial);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@contacto", contacto);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Nuevo Proveedor agregado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se pudo agregar el nuevo Proveedor.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el nuevo Proveedor: " + ex.Message);
            }

            connection.Close();
        }
        public void ModificarProveedor(int id_proveedor, string razonSocial, string ruc, string contacto, string direccion)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Proveedores SET RazonSocial = @razonSocial, Ruc = @ruc, Contacto = @contacto, Direccion = @direccion WHERE Id_Proveedor = @id_proveedor";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                    command.Parameters.AddWithValue("@razonSocial", razonSocial);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@contacto", contacto);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Proveedor modificado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún Proveedor con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al modificar el Proveedor: " + ex.Message);
            }
            connection.Close();
        }
        public void EliminarProveedor(int id_proveedor)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Proveedores WHERE Id_Proveedor = @id_proveedor";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Proveedor eliminado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún Proveedor con el ID especificado.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al eliminar el Proveedor: " + ex.Message);
            }
            connection.Close();
        }
        public ArrayList ObtenerProveedorPorId(int id_proveedor)
        {
            connection.Open();
            ArrayList Proveedor = null;

            try
            {
                string query = "SELECT RazonSocial, Ruc, Contacto, Direccion " +
                               "FROM Proveedores WHERE Id_Proveedor = @id_proveedor";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID del cliente
                    command.Parameters.AddWithValue("@id_proveedor", id_proveedor);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Proveedor = new ArrayList
                            {
                                reader["RazonSocial"],
                                reader["Ruc"],
                                reader["Contacto"],
                                reader["Direccion"]
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el Proveedor: " + ex.Message);
            }
            connection.Close();
            return Proveedor;
        }

        //Metodos para Pedido
        public int AgregarNuevoPedido(int id_cliente, string Fecha, int id_empleado, int MontoTotal, int Id_TipoPago)
        {
            connection.Open();
            int ultimoNumero = 0;
            try
            {
                string query = "INSERT INTO Pedidos (Id_Cliente, Fecha, Id_empleado, MontoTotal, Id_TipoPago) " +
                               "VALUES (@id_cliente, @Fecha, @id_empleado, @MontoTotal, @Id_TipoPago)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_cliente", id_cliente);
                    command.Parameters.AddWithValue("@Fecha", "2023-09-12");
                    command.Parameters.AddWithValue("@id_empleado", id_empleado);
                    command.Parameters.AddWithValue("@MontoTotal", MontoTotal);
                    command.Parameters.AddWithValue("@Id_TipoPago", Id_TipoPago);
                    command.ExecuteNonQuery();
                }
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT MAX(Id_Pedido) FROM Pedidos", connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            ultimoNumero = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el nuevo Pedido: " + ex.Message);
            }           

            connection.Close();
            return ultimoNumero ;
        }
        public void AgregarNuevoDetallePedido(int id_pedido, int id_producto, int Cantidad, int PrecioUnitario, int PrecioTotal)
        {
            connection.Open();
            try
            {

                string query =
                    "INSERT INTO DetalleDePedidos (Id_Pedido, Id_Producto, Cantidad, PrecioUnitario, PrecioTotal) " +
                               "VALUES (@id_pedido, @id_producto, @Cantidad, @PrecioUnitario, @PrecioTotal)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_pedido", id_pedido);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);
                    command.Parameters.AddWithValue("@id_producto", id_producto);
                    command.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                    command.Parameters.AddWithValue("@PrecioTotal", PrecioTotal);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el nuevo Pedido: " + ex.Message);
            }
            connection.Close();
        }
        public void InsertarBoleta(string fecha, bool estadoPedido, int idPedido)
        {
            connection.Open();
            try
            {
                string query = "INSERT INTO Boleta (Fecha, EstadoPedido, Id_Pedido) VALUES (@Fecha, @EstadoPedido, @IdPedido)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Fecha", "2023-09-12");
                    command.Parameters.AddWithValue("@EstadoPedido", estadoPedido);
                    command.Parameters.AddWithValue("@IdPedido", idPedido);
                    command.ExecuteNonQuery();
                }          
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar la nueva Boleta: " + ex.Message);
            }

            connection.Close();
        }
        public void RetirarProductos(int idProducto, int cantidad)
        {
            connection.Open();
            try
            {
                // Actualizar la cantidad de stock
                string query = "UPDATE Producto SET CantStock = CantStock - @Cantidad WHERE Id_Producto = @IdProducto";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al quitar productos: " + ex.Message);
            }
            connection.Close();
        }
        //Metodos para Consulta
        public DataTable ObtenerDetallePedido(int id_pedido)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT  DP.id_producto, P.Descripcion, DP.Cantidad, DP.PrecioUnitario, DP.PrecioTotal " +
                                                                    "FROM DetalleDePedidos DP INNER JOIN Producto P ON P.id_producto = DP.id_producto " +
                                                                    "WHERE id_pedido =" + id_pedido, connection))
                {
                    adapter.Fill(dataTable);
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            connection.Close();
            return dataTable;
        }

        //Metodos para Empleado y Usuario

        public void AgregarEmpleado(string dni, string cargo, string usuario, string contraseña)
        {
            connection.Open();

            int id_usuario = 0;
            try
            {
                string query = "INSERT INTO Usuarios (Usuario, Contraseña, Id_TipoEstado) " +
                               "VALUES (@usuario, @contraseña, 2)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand("SELECT MAX(Id_usuario) FROM Usuarios", connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        id_usuario = Convert.ToInt32(result);
                    }
                }

                query = "INSERT INTO Empleados (Dni, Id_TipoCargo, Id_Usuario) " +
                               "VALUES (@dni, @Id_TipoCargo, @Id_Usuario);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@Id_TipoCargo", cargo);
                    command.Parameters.AddWithValue("@Id_Usuario", id_usuario);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Nuevo Empleado agregado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se pudo agregar el nuevo Empleado.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al agregar el nuevo Empleados: " + ex.Message);
            }

            connection.Close();
        }
        public void ModificarEmpleado(int id_empleado, string dni, string cargo, string usuario, string contraseña)
        {
            int id_usuario = 0;
            try
            {
                connection.Open();
                string query = "UPDATE Empleados SET Dni = @dni, Id_TipoCargo = @Id_TipoCargo WHERE Id_Empleado = @Id_Empleado;";                               

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id_Empleado", id_empleado);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@Id_TipoCargo", cargo);

                    command.ExecuteNonQuery();

                }

                using (MySqlCommand command = new MySqlCommand("SELECT Id_Usuario FROM Empleados WHERE Id_Empleado = @id_empleado", connection))
                {
                    command.Parameters.AddWithValue("@Id_Empleado", id_empleado);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        id_usuario = Convert.ToInt32(result);
                    }
                }

                query = "UPDATE Usuarios SET Usuario = @usuario, Contraseña = @contraseña  WHERE Id_Usuario = @id_usuario;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega parámetros para evitar problemas de seguridad e inyección de SQL
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Empleado modificado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún Empleado con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al modificar el Empleado: " + ex.Message);
            }
            connection.Close();
        }
        public void EliminarEmpleado(int id_empleado)
        {
            int id_usuario = 0;
            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT Id_Usuario FROM Empleados WHERE Id_Empleado = @id_empleado", connection))
                {
                    command.Parameters.AddWithValue("@id_empleado", id_empleado);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        id_usuario = Convert.ToInt32(result);
                    }
                }
          
                string query = "DELETE FROM Empleados WHERE Id_Empleado = @id_empleado;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_empleado", id_empleado);
                    command.ExecuteNonQuery();                  
                }

                query = "DELETE FROM Usuarios WHERE Id_Usuario = @id_usuario";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        System.Windows.MessageBox.Show("Empleado eliminado correctamente.");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No se encontró ningún cliEmpleadoente con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al eliminar el Empleado: " + ex.Message);
            }
            connection.Close();
        }
        public ArrayList ObtenerEmpleadoPorId(int id_empleado)
        {
            connection.Open();
            ArrayList empleado = null;

            try
            {
                string query = "SELECT E.Dni, C.TipoDeCargo, U.Usuario, U.Contraseña " +
                               "FROM Empleados E INNER JOIN Usuarios U ON U.Id_Usuario =  E.Id_Usuario " +
                               "INNER JOIN Cargo C ON C.Id_TipoCargo = E.Id_TipoCargo " +
                               "WHERE Id_Empleado = @id_empleado;";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID del cliente
                    command.Parameters.AddWithValue("@id_empleado", id_empleado);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new ArrayList
                            { 
                                reader["Dni"],
                                reader["TipoDeCargo"],
                                reader["Usuario"],
                                reader["Contraseña"]
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el Empleado: " + ex.Message);
            }
            connection.Close();
            return empleado;
        }
    }
}

