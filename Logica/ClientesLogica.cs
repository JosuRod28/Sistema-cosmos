using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COSMOSCOM.Modelo;
using Microsoft.VisualBasic.Devices;

namespace COSMOSCOM.Logica
{
    //Clase ClientesLógic
    public class ClientesLogica
    {
        //Variable de tipo string que guarda la conexion a la bd
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        //Variable de instancia
        private static ClientesLogica _instancia = null;
        // Constructor privado para evitar la creación de instancias externas
        public ClientesLogica()
        {


        }

        //Propiedad estatica 
        public static ClientesLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ClientesLogica();
                }
                return _instancia;
            }


        }

        //Metodo para seleccionar el ID disponible del siguiente cliente registrado
        public int idCliente()
        {
            //Variable idCliente que inicia en 1;
            int idCliente = 1 ;
            //Variable de tipo cadena para realizar la consulta
           
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                 
                try
                {   //Establecer la conexión a la base de datos
                    string query = "SELECT COALESCE(MAX(id_Cliente) + 1, 1) FROM Clientes;";
                    
                    //abrir la conexión de base de datos
                    connection.Open();
                    //Crear un comando SQLite con la consulta proporcionada
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    //Establecer el tipo de comando como texto (consultar SQL estándar)
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Ejecutar la consulta y obtener el resultado
                    object result = cmd.ExecuteScalar();

                    // Verificar si se obtuvo un resultado no nulo
                    if (result != null && result != DBNull.Value)
                    {
                        //Convertir el resultado a entero y asignarle la variable idCliente
                        idCliente = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Capturar cualquier excepción que ocurredurante la ejecución.
                    // Mostrar un mensaje de error con la descripción de la excepción.
                    MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                }
            }
            return idCliente;
        }
        // Metodo para guardar el resgistro en la base de datos.
        public bool Guardar(Clientes obj)
        {
            //Variable de tipo booleano 
            bool respuesta = true;
            // Se establece la conexion a la base de datos
            using(SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                   //Se abre la conexión a la base de datos
                    conn.Open();
                   //Se crea la variable de tipo cadena para guardar la consulta
                    string queryInsertar = "INSERT INTO Clientes(id_Cliente,Nombre, Apellido_P, Apellido_M, Telefono1, Telefono2) VALUES (@id_cliente,@nombre, @apellido_p, @apellido_m, @telefono1, @telefono2)";
                    SQLiteCommand cmdInsertar = new SQLiteCommand(queryInsertar, conn);
                    //Agregar parámetros para cada uno de las entidades asignando el valor de cada propiedad del objeto obj.
                    cmdInsertar.Parameters.AddWithValue("@id_cliente",obj.id_Cliente);
                    cmdInsertar.Parameters.AddWithValue("@nombre", obj.Nombre);
                    cmdInsertar.Parameters.AddWithValue("@apellido_p", obj.Apellido_P);
                    cmdInsertar.Parameters.AddWithValue("@apellido_m", obj.Apellido_M);
                    cmdInsertar.Parameters.AddWithValue("@telefono1", obj.Telefono1);
                    cmdInsertar.Parameters.AddWithValue("@telefono2", obj.Telefono2);

                // Si la ejecución no afecta a ninguna fila (< 1), se establece respuesta como false.
                // Ejecutar el comando SQL de inserción y verificar el número de filas afectadas.
                if (cmdInsertar.ExecuteNonQuery() < 1)
                    {
                    // Si no se ha insertado ninguna fila, la respuesta se establece en false.
                    respuesta = false;
                    }
                

            }
            return respuesta;

        }


        // Metodo de tipo booleano que consulta si existe un cliente con un ID específico.
        public bool ver_idCliente(int idCliente)
        {
            // Inicializar la variable de respuesta como falsa. Se asume que el cliente no existe.
            bool respuesta = false;
            // Usar una conexión a la base de datos SQLite que se cerrará automáticamente al salir del bloque.
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                // Abrir la conexión a la base de datos.
                conn.Open();
                // Consulta SQL para contar cuántos registros existen en la tabla Clientes con un ID específico.
                string queryVerificacion = "SELECT COUNT(*) FROM Clientes WHERE id_Cliente = @id_cliente";
                // Crear un comando SQLite con la consulta y la conexión establecida.
                SQLiteCommand cmdVerificacion = new SQLiteCommand(queryVerificacion, conn);
                // Agregar un parámetro al comando para el ID del cliente.
                cmdVerificacion.Parameters.AddWithValue("@id_cliente",idCliente );

                // Ejecutar la consulta y obtener el número de registros encontrados.
               
                int cantidadRegistros = Convert.ToInt32(cmdVerificacion.ExecuteScalar());
                // Si ya existe un registro con la misma clave primaria, abortar la inserción
                if (cantidadRegistros > 0)
                {
                    respuesta = true;
                }
            }
            // Retornar el resultado de la verificación.
            return respuesta;
        }
        

        //Metodo para consultar todos los clientes registrados.
        public List<Clientes> consultarTodos()
        {
            //Crear objeto olista que almacene los resultados de la consulta
            List<Clientes> olista = new List<Clientes>();

            //Hacer la conexión a la base de datos SQLite.
            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {
                //Abrir la conexión a la base de datos.
                conn.Open();
                //Crear consulta para seleccionar todos lo clientes registrados.
                string query = "select * from Clientes";
                //Crear un comando SQL con la consulta y la conexión establecida.
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                //Específicar que el tipo de comando es texto, lo que significa que se va a ejecutar el comando SQL en formato texto
                cmd.CommandType = System.Data.CommandType.Text;
                //Ejecutar la consulta y obtener un lector de datos para recorrer los resultados.
                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    //Leer los resultados fila por fila.
                    while (dataReader.Read())
                    {
                        // Crear un nuevo objeto Clientes y asignar valores a sus propiedades desde las columnas del resultado.
                        olista.Add(new Clientes()
                        {

                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    // Cerrar el lector de datos.
                    dataReader.Close();
                }
                // Cerrar la conexión a la base de datos.
                conn.Close();
            }
            // Retornar la lista de objetos Clientes que se ha rellenado con los datos de la base de datos.
            return olista;

        }

        //Metodo para consultar los clientes por nombre
        public List<Clientes> consulta_nombre(string nombre)
        {
            
            List<Clientes> olista = new List<Clientes>();
            
            using (SQLiteConnection conn = new SQLiteConnection(conexion)) 
        
            {
                
                conn.Open();
                string query= "select * from Clientes WHERE Nombre = @nombre ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre",nombre);

                cmd.CommandType=System.Data.CommandType.Text;

                using(SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });
                            
                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

         }

        //Metodo para consultar los clientes por apellido paterno
        public List<Clientes> consulta_apellido_p(string apellido_p)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Apellido_P = @apellido_p ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@apellido_p", apellido_p);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        //Metodo para consultar los nombres por apellido materno
        public List<Clientes> consulta_apellido_m(string apellido_m)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Apellido_M = @apellido_m";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@apellido_m", apellido_m);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        //Metodo para consultar los cliente por teléfono 1
        public List<Clientes> consulta_telefono1(string telefono1)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Telefono1 = @telefono1 ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefono1", telefono1);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        //Metodo para consultar los clientes por telefono 2
        public List<Clientes> consulta_telefono2(string telefono2)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Telefono2 = @telefono2 ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefono2", telefono2);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });
                       


                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }
        //Metodo para eliminar  un cliente de la base de datos.
        public bool Eliminar(int id)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Clientes WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", id);
                int filasAfectadas = cmd.ExecuteNonQuery(); // Obtiene el número de filas afectadas por la operación
              
                if (filasAfectadas> 0)
                {
                    respuesta = true; // Si se eliminó al menos una fila, establece la respuesta como true
                }
                conn.Close ();
            }
            return respuesta; 
        }

        //Metodo de tipo booleano que verifica si hay un ID de un cliente existente en la tabla de Ventas
        public bool refFKVentas(int idCliente)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query1 = "SELECT COUNT(*) FROM Venta_Total WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;

            }
        }

        //Metodo de tipo booleano que verifica si hay un ID de un cliente existente en la tabla de detalles de venta.
        public bool refFKDetalleVentas(int idCliente)
        {
            //abre la conexión  a la base de datos.
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                //Se abre la conexión a la base de datos.
                conn.Open();
                string query1 = "SELECT COUNT(*) FROM Detalle_Venta WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;

            }

        }

        //MEtodo de tipo booleano para actualizar cliente
        public bool ActualizarCliente(string queryActualiza)
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












    }
}
