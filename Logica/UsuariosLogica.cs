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
    public  class UsuariosLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private ConexionBD conexionBD = new ConexionBD();
        private static UsuariosLogica _instancia = null;
        public UsuariosLogica()
        {


        }

        public static UsuariosLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsuariosLogica();
                }
                return _instancia;
            }


        }


        public List<Usuarios> ListUsuarios()
        {

            List<Usuarios> olista = new List<Usuarios>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Usuarios()
                        {
                            id_Usuario = int.Parse(dataReader["id_usuario"].ToString()),
                            Usuario = dataReader["usuario"].ToString(),
                            Clave = dataReader["clave"].ToString(),
                            id_Rol = int.Parse(dataReader["id_Rol"].ToString()),
                            Correo= dataReader["correo"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool IngresarNuevoAdmin(Usuarios admin)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
  
                    conn.Open();
                    string query = "INSERT INTO Usuarios (usuario,clave,correo,id_Rol) values (@nuevoUsuario,@nuevaClave,@correo,@id_rol)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nuevoUsuario", admin.Usuario);
                        cmd.Parameters.AddWithValue("@nuevaClave", admin.Clave);
                        cmd.Parameters.AddWithValue("@correo", admin.Correo);
                        cmd.Parameters.AddWithValue("@id_rol", admin.id_Rol);
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (cmd.ExecuteNonQuery() < 1)
                        {

                            respuesta = false;

                        }
                    }
                    conn.Close();
                }
                
            }catch(Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrar el error o mostrar un mensaje al usuario)
                Console.WriteLine($"Error al ingresar un nuevo administrador: {ex.Message}");
                respuesta = false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }


            return respuesta;

        }        
        public bool InsertarNuevoUsuario(Usuarios user)
        
        {
            bool respuesta = true;

            try
            {
                    using (SQLiteConnection conn = new SQLiteConnection(conexion))
                    {

                        conn.Open();
                        string query = "INSERT INTO Usuarios (usuario,clave,correo,id_Rol) values (@nuevoUsuario,@nuevaClave,@correo,@id_rol)";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nuevoUsuario", user.Usuario);
                            cmd.Parameters.AddWithValue("@nuevaClave", user.Clave);
                            cmd.Parameters.AddWithValue("@id_rol", user.id_Rol);
                            cmd.Parameters.AddWithValue("@correo", user.Correo);
                            cmd.CommandType = System.Data.CommandType.Text;

                            if (cmd.ExecuteNonQuery() < 1)
                            {

                                respuesta = false;

                            }
                        }
                        conn.Close();

                    }
            }catch(Exception ex)
            {
                Console.WriteLine($"Error al ingresar un nuevo administrador: {ex.Message}");
                respuesta = false;
            }
            finally
            {
                conexionBD.CerrarConexion();
            }


            return respuesta;
        }

        public bool VerificarAdminExistente(Usuarios admin)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios where id_Rol = @id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_rol", admin.id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool Eliminar(int idUsuario)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {

                conn.Open();
                string query = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                int filasAfectadas = cmd.ExecuteNonQuery(); // Obtiene el número de filas afectadas por la operación

                if (filasAfectadas > 0)
                {
                    respuesta = true; // Si se eliminó al menos una fila, establece la respuesta como true
                }
                conn.Close();
            }
            return respuesta;
        }

        public bool ActualizarUsuario(string queryActualiza)
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
