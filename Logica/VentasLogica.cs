using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Logica
{
    public class VentasLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private static VentasLogica _instancia = null;
        public VentasLogica()
        {

        }

        public static VentasLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new VentasLogica();
                }
                return _instancia;
            }


        }

        public int idCliente()
        {
            int idCliente = 1;
            
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                string query = "SELECT COALESCE(MAX(id_Cliente) + 1, 1) FROM Clientes;";
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Ejecutar la consulta y obtener el resultado
                    object result = cmd.ExecuteScalar();

                    // Verificar si se obtuvo un resultado no nulo
                    if (result != null && result != DBNull.Value)
                    {
                        idCliente = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                }
            }
            return idCliente;
        }

        public bool Guardar(Ventas obj)
        {
            int idCliente = ObtenerIdCliente();
            bool respuesta = true;
            
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                    string queryInsert = "INSERT INTO Venta_Total(Folio,id_Cliente,Fecha_de_atencion,Fecha_de_entrega,Total) values (@folio,@id_cliente,@fecha_de_atencion,@fecha_de_entrega,@total)";
                    SQLiteCommand cmdInsert = new SQLiteCommand(queryInsert, conn);
                    cmdInsert.Parameters.Add(new SQLiteParameter("@folio", obj.Folio));
                    cmdInsert.Parameters.Add(new SQLiteParameter("@id_cliente", idCliente));
                    cmdInsert.Parameters.Add(new SQLiteParameter("@fecha_de_atencion", obj.Fecha_de_atencion));
                    cmdInsert.Parameters.Add(new SQLiteParameter("@fecha_de_entrega", obj.Fecha_de_entrega));
                    cmdInsert.Parameters.Add(new SQLiteParameter("@total", obj.Total));
                    cmdInsert.CommandType = System.Data.CommandType.Text;

                    if (cmdInsert.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }

            }


            return respuesta;

        }

        private int ObtenerIdCliente()
        {
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                string query = "SELECT (MAX(id_Cliente)) FROM Clientes;";
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Ejecutar la consulta y obtener el resultado
                    object result = cmd.ExecuteScalar();

                    // Verificar si se obtuvo un resultado no nulo
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                }
            }
            return -1;
        }

        public bool BuscarFechasEntrega(string Fecha_entrega)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion)) 
            {

                conn.Open();
                string querySelectFecha = "select * from Venta_Total where Fecha_de_entrega=@fecha_de_entrega";
                SQLiteCommand cmdSelectFecha = new SQLiteCommand(querySelectFecha, conn);
                cmdSelectFecha.Parameters.AddWithValue("@fecha_de_entrega", Fecha_entrega);
                cmdSelectFecha.CommandType = System.Data.CommandType.Text;
                int count = Convert.ToInt32(cmdSelectFecha.ExecuteScalar());

                // Si count es mayor que 0, significa que hay al menos un registro con la fecha de entrega proporcionada
                return count > 0;

            }
        }

        public List<Ventas> ConsultarTodos()
        {
            List<Ventas> olista = new List<Ventas>();
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "select * from Venta_Total";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),



                        });

                    }
                }
            }

            return olista;

        }

        public List<Ventas> ConsultarPorFolio(int folio)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Folio = @folio ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio", folio);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }


        public List<Ventas> ConsultaPorCliente(int idCliente)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE id_Cliente = @id_cliente ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> ConsultarPorFechaAtencion(string fecha_atencion)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Fecha_de_atencion = @fecha_de_atencion";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha_de_atencion", fecha_atencion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> ConsultarPorFechaEntrega(string fecha_entrega)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Fecha_de_entrega = @fecha_de_entrega";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha_de_entrega", fecha_entrega);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> consultarTotal(string total)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Total = @total";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@total", total);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_de_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_de_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool EliminarVenta(int folio)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Venta_Total WHERE Folio = @folio";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio", folio);
                int filasAfectadas = cmd.ExecuteNonQuery(); // Obtiene el número de filas afectadas por la operación

                if (filasAfectadas > 0)
                {
                    respuesta = true; // Si se eliminó al menos una fila, establece la respuesta como true
                }
                conn.Close();
            }
            return respuesta;
        }

        public bool ActualizarVentas(string queryActualiza)
        {
            try
            {   
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();

                    SQLiteCommand cmd = new SQLiteCommand(queryActualiza, conn);

                    // Ejecutar la consulta de actualización
                    int filasActualizadas = cmd.ExecuteNonQuery();
                    // Verificar si se actualizaron filas
                    return filasActualizadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }

        }

        public bool InsertarDetalleVenta(string formato,string duracion, string monto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();
                    string InsertDetalleVenta = "INSERT INTO Detalle_Venta(Folio_Venta,id_Cliente,id_Formato,Duracion,Monto) values ((SELECT MAX(Folio) FROM Venta_Total),(SELECT MAX(id_Cliente) FROM Clientes),(SELECT id_Formato  from Formatos where Formato=@id_formato),@duracion,@monto)";
                    SQLiteCommand cmdDetalleVenta = new SQLiteCommand(InsertDetalleVenta, conn);
                    cmdDetalleVenta.Parameters.AddWithValue("@id_formato", formato);
                    cmdDetalleVenta.Parameters.AddWithValue("@duracion", duracion);
                    cmdDetalleVenta.Parameters.AddWithValue("@monto",monto);

                    // Ejecutar el comando para realizar la inserción de datos
                    int filasInsertadas = cmdDetalleVenta.ExecuteNonQuery();

                    // Devolver true si se insertaron filas correctamente, de lo contrario, devolver false
                    return filasInsertadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }

        }

        public bool ver_Folio(int folio)
        {
            bool respuesta = false;

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                // Verificar si ya existe un registro con la misma clave primaria
                string queryVerificacion = "SELECT COUNT(*) FROM Venta_Total WHERE Folio = @folio";
                SQLiteCommand cmdVerificacion = new SQLiteCommand(queryVerificacion, conn);
                cmdVerificacion.Parameters.AddWithValue("@folio", folio);
                int cantidadRegistros = Convert.ToInt32(cmdVerificacion.ExecuteScalar());
                // Si ya existe un registro con la misma clave primaria, abortar la inserción
                if (cantidadRegistros > 0)
                {

                    respuesta = true;
                }
            }
            return respuesta;
        }

        public bool ver_FKCliente(int idCliente)
        {
            bool respuesta = false;

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                // Verificar si ya existe un registro con la misma clave primaria
                string queryVerificacion = "SELECT COUNT(*) FROM Venta_Total WHERE id_Cliente=@id_cliente";
                SQLiteCommand cmdVerificacion = new SQLiteCommand(queryVerificacion, conn);
                cmdVerificacion.Parameters.AddWithValue("@id_cliente", idCliente);
                int cantidadRegistros = Convert.ToInt32(cmdVerificacion.ExecuteScalar());
                // Si ya existe un registro con la misma clave primaria, abortar la inserción
                if (cantidadRegistros > 0)
                {

                    respuesta = true;
                }
            }
            return respuesta;
        }
    }
}
