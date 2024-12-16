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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class Clave_Administrador : Form
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private ConexionBD conexionBD = new ConexionBD();
        private Bienvenido bienvenidosForm;
        public Clave_Administrador()
        {
            InitializeComponent();
            ApplyBgImage();
            txt_claveAdmin.UseSystemPasswordChar = true;
            txt_claveAdmin.PasswordChar = '*';
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

        private void SetBackgroundImage(Clave_Administrador clave_Administrador, Image backgroundImage)
        {
            clave_Administrador.BackgroundImage = backgroundImage;
            clave_Administrador.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RemoveBackgroundImage(Clave_Administrador clave_Administrador)
        {
            clave_Administrador.BackgroundImage = null;
        }

        private void SetBackgroundColor(Clave_Administrador clave_Administrador, Color backgroundColor)
        {
            clave_Administrador.BackColor = backgroundColor;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            Bienvenido? campo = Application.OpenForms.OfType<Bienvenido>().FirstOrDefault();
            
          
            int idRolUser = 2;
            Usuarios nuevoUsuario = new Usuarios()
            {
                Usuario = campo.TextBox_Usuario.Text,
                Clave = campo.Textbox_Clave.Text,
                Correo=campo.Textbox_Correo.Text,
                id_Rol = idRolUser,
            };
            int idRolAdmin = 1;
            Usuarios admin = new Usuarios()
            {
                Clave = txt_claveAdmin.Text,
                id_Rol=idRolAdmin
            };

   
            if (ValidarAdmin(admin))
            {       
                bool UserExist = VerificarUsuarioExistente(nuevoUsuario);
                if (UserExist)
                {

                    MessageBox.Show("Ya existe un usuario con los datos ingresados, por favor ingrese otro usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                    bool resp = UsuariosLogica.Instancia.InsertarNuevoUsuario(nuevoUsuario);
                    if (resp)
                    {
                        MessageBox.Show("Usuario creado correctamente,inicia sesión", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        campo.Textbox_Clave.Text = "";
                        campo.Textbox_Correo.Text = "";
                        campo.TextBox_Usuario.Text = "";

                    }
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta vuelva a intentarlo", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

         }
        private void BienvenidosForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            bienvenidosForm = null;
        }

        private bool ValidarAdmin(Usuarios admin)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE clave = @clave AND id_Rol=@idRol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@clave", admin.Clave);
                cmd.Parameters.AddWithValue("@idRol",admin.id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private bool VerificarUsuarioExistente(Usuarios nuevoUsuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios where usuario =@usuario AND clave =@clave AND correo=@correo";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", nuevoUsuario.Usuario);
                cmd.Parameters.AddWithValue("@clave", nuevoUsuario.Clave);
                cmd.Parameters.AddWithValue("@correo", nuevoUsuario.Correo);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }



        private void Clave_Administrador_Load(object sender, EventArgs e)
        {
            conexionBD.AbrirConexion(conexion);
        }
    }
}
