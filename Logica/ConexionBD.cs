using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace COSMOSCOM.Logica
{
    public class ConexionBD
    {
        private SQLiteConnection conn;
        public void AbrirConexion(string conexion)
        {
            if (conn != null)
            {
                conn.Close();   
                conn.Dispose();
            }
            conn = new SQLiteConnection(conexion);
            conn.Open();
        }

        public void CerrarConexion()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }



    }
}
