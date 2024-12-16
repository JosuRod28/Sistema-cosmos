using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace COSMOSCOM.Logica
{
    //Clase ClientesLógic
    public class DetalleVentaLogica
    {
        //Variable de tipo string que guarda la conexion a la bd
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //Variable de instancia
        private static DetalleVentaLogica _instancia = null;

        // Constructor privado para evitar la creación de instancias externas
        public DetalleVentaLogica()
        {

        }

        //Propiedad estatica 
        public static DetalleVentaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DetalleVentaLogica();
                }
                return _instancia;
            }

        }
        //Metodo para seleccionar el ID del último cliente registrado
        public int ObteneridCliente()
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

        //Metodo para insertar el detalle de venta
        public bool InsertarDetalleVenta (int folioVenta, List<DetalleVenta> detallesVenta)
        {
            int idCliente = ObteneridCliente();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();
                    foreach (var detalle in detallesVenta)
                    {
                        // Construir la consulta para insertar cada detalle de venta
                        string query = "INSERT INTO Detalle_Venta(Folio_Venta, id_Cliente, Formato, Duracion, Monto) " +
                                       "VALUES (@folioVenta, @idCliente, @formato, @duracion, @monto);";
                        SQLiteCommand cmdDetalleVenta = new SQLiteCommand(query, conn);

                        // Establecer los parámetros de la consulta para el detalle actual
                        cmdDetalleVenta.Parameters.AddWithValue("@folioVenta", folioVenta);
                        cmdDetalleVenta.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdDetalleVenta.Parameters.AddWithValue("@formato", detalle.Formato); // Supongo que tienes un campo IdFormato en tu clase DetalleVenta
                        cmdDetalleVenta.Parameters.AddWithValue("@duracion", detalle.Duracion);
                        cmdDetalleVenta.Parameters.AddWithValue("@monto", detalle.Monto);

                        // Ejecutar la consulta para insertar el detalle de venta actual
                        cmdDetalleVenta.ExecuteNonQuery();


                    }
                    // Devolver true si se insertaron todos los detalles de venta correctamente
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al insertar datos " + ex.Message);
                return false;
            }

        }


        //Metodo para listar los detalles de la venta
        public List<DetalleVenta> ListarDetalleVenta(int folio )
        {

            List<DetalleVenta> olista = new List<DetalleVenta>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Detalle_Venta WHERE Folio_Venta=@folio_venta" ;
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio_venta", folio);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new DetalleVenta()
                        {
                           Folio_Venta= int.Parse(dataReader["Folio_Venta"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Formato = dataReader["Formato"].ToString(),
                            Duracion = dataReader["Duracion"].ToString(),
                            Monto = dataReader["Monto"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool EliminarDetalleVenta(int folio)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Detalle_Venta WHERE Folio_Venta = @folio";
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
    }
}
