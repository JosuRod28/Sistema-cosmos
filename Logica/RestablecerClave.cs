using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Logica
{
    public class RestablecerClave
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private static RestablecerClave _instancia = null;

        public RestablecerClave()
        {

        }
        public static RestablecerClave Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new RestablecerClave();
                }
                return _instancia;
            }


        }

        public void ActualizarPassword(string nuevaClave, int idUsuario)
        {
            
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();
                    string query = $"UPDATE Usuarios SET clave = @nuevaClave WHERE id_usuario = @id_usuario";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nuevaClave",nuevaClave);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    // Imprimir el query con los parámetros
                    string formattedQuery = query.Replace("@nuevaClave", "'" + nuevaClave + "'").Replace("@correo", "'" + idUsuario+ "'");
                    Debug.WriteLine("Executing query: " + formattedQuery);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                       
                      MessageBox.Show("La contraseña se actualizo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la contraseña", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al actualizar la contraseña: " + ex.Message);
                
            }


        }

        public int ObtenerUsuario(string emailUsuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT id_usuario FROM Usuarios WHERE correo = @correo";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@correo", emailUsuario);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1;
        }

    }
}
