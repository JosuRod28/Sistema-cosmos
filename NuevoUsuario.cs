using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class NuevoUsuario : Form
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private AdministraUsuarios _administraUsuarios;
        public NuevoUsuario(AdministraUsuarios administraUsuarios)
        {
            InitializeComponent();
            txtNuevoPasswd.UseSystemPasswordChar = true;
            txtNuevoPasswd.PasswordChar = '*';
            _administraUsuarios = administraUsuarios;

            ApplyBgImage();
        }

        private void ApplyBgImage()
        {
            string backgroundImagePath = Properties.Settings.Default.BackgroundImagePath;
            if (!string.IsNullOrEmpty(backgroundImagePath) && System.IO.File.Exists(backgroundImagePath))
            {
                Image backgroundImage = Image.FromFile(backgroundImagePath);
                SetBackgroundImage(this, backgroundImage);
            }
            else
            {
                Color backgroundColor = Properties.Settings.Default.BackgroundColor;
                SetBackgroundColor(this, backgroundColor);
                RemoveBackgroundImage(this);
            }
        }

        private void RemoveBackgroundImage(NuevoUsuario nuevoUsuario)
        {
            nuevoUsuario.BackgroundImage = null;
        }

        private void SetBackgroundColor(NuevoUsuario nuevoUsuario, Color backgroundColor)
        {
            nuevoUsuario.BackColor = backgroundColor;
            nuevoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SetBackgroundImage(NuevoUsuario nuevoUsuario, Image backgroundImage)
        {
            nuevoUsuario.BackgroundImage = backgroundImage;
            nuevoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string? rol = cbRoles.SelectedItem?.ToString();
            int idRol = 0;


            if (!string.IsNullOrEmpty(rol))
            {

                switch (rol)
                {
                    case "admin":
                        idRol = 1;
                        break;
                    case "user":
                        idRol = 2;

                        break;
                    default:
                        idRol = 0;
                        break;
                }
            }


            Usuarios nuevoUsuario = new Usuarios()
            {
                Usuario = txtNuevoUsuario.Text,
                Clave = txtNuevoPasswd.Text,
                id_Rol = idRol,
            };


                bool respuesta = UsuariosLogica.Instancia.InsertarNuevoUsuario(nuevoUsuario);
                if (respuesta)
                {
                    MessageBox.Show("¡Usuario nuevo ingresado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _administraUsuarios.ActualizarDataGridView();
                    SeleccionarUsuario();


                }
                else
                {
                    MessageBox.Show("Algo salió mal intentelo de nuevo", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            
        }
        private void SeleccionarUsuario()
        {

            Autenticacion nuevoitem = Application.OpenForms.OfType<Autenticacion>().FirstOrDefault();
            if (nuevoitem != null) // Verificar si nuevoitem no es nulo)
            {
                using (SQLiteConnection connection = new SQLiteConnection(conexion))
                {
                    // Consulta SQL para obtener los nombres de la tabla Usuarios
                    string query = "SELECT usuario FROM Usuarios";
                    // Crear un comando SQL con la consulta y la conexión
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    // Abrir la conexión
                    connection.Open();
                    // Ejecutar la consulta y obtener los resultados
                    SQLiteDataReader reader = command.ExecuteReader();
                    // Recorrer los resultados y agregar cada nombre al ComboBox
                    while (reader.Read())
                    {
                        // Verificar si nuevoitem.ComboBoxAutenticaion no es nulo antes de intentar acceder a él
                        if (nuevoitem.ComboBoxAutenticaion != null)
                        {
                            // Verificar si el ítem ya está en el ComboBox antes de agregarlo
                            if (!nuevoitem.ComboBoxAutenticaion.Items.Contains(reader["usuario"].ToString()))
                            {
                                nuevoitem.ComboBoxAutenticaion.Items.Add(reader["usuario"].ToString());
                            }
                        }
                    }
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
