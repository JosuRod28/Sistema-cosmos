using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Logica
{
    public class Formatos
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private static Formatos _instancia = null;
        public Formatos()
        {


        }
        public static Formatos Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Formatos();
                }
                return _instancia;
            }


        }
        public string TipoFormato { get; private set; }

        public List<Formatos> ObtenerFormatos()
        {
            List<Formatos> formatos = new List<Formatos>();
            string query = "Select Formato from Formatos";
            using (SQLiteConnection connection = new SQLiteConnection (conexion))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            string tipoFormato = dataReader.GetString(0);

                            formatos.Add(new Formatos { TipoFormato = tipoFormato });
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error al cargar los formatos: " + ex.Message);
                }
            }
            return formatos;
        }

    }
}
