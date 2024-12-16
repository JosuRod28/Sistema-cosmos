using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COSMOSCOM
{
    public partial class Autenticacion : Form

    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private ConexionBD conexionBD = new ConexionBD();
        private Bienvenido  bienvenidosForm;
        public Autenticacion()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
            txtClave.PasswordChar = '*';
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

        private void RemoveBackgroundImage(Autenticacion autenticacion)
        {
            autenticacion.BackgroundImage = null;
        }

        private void SetBackgroundColor(Autenticacion autenticacion, Color backgroundColor)
        {
            autenticacion.BackColor = backgroundColor;
        }

        private void SetBackgroundImage(Autenticacion autenticacion, Image backgroundImage)
        {
            autenticacion.BackgroundImage = backgroundImage;
            autenticacion.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public ComboBox ComboBoxAutenticaion
        {
            get { return cbUsuarios; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Registro_admin_ registro_admin;
        private Registro_user_ registro_user;
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtClave.Text) && cbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbUsuarios.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese un una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();

                return;
            }


            Usuarios usuarios = new Usuarios()
            {
                Usuario = cbUsuarios.Text,
                Clave = txtClave.Text,
            };


            if (ValidarUsuario(usuarios))
            {

                if (RolAdmin(cbUsuarios.Text))
                {
                    registro_admin = new Registro_admin_();
                    registro_admin.Show();
                    this.Close();
                    MessageBox.Show("Login Exitoso");

                }

                if (RolUser(cbUsuarios.Text))
                {
                    registro_user = new Registro_user_();
                    registro_user.Show();
                    this.Close();
                    MessageBox.Show("Login Exitoso");

                }


            }
            else
            {
                MessageBox.Show("Contraseña incorrecta","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }




        private bool RolAdmin(string usuario)
        {

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                int id_Rol = 1;
                conn.Open();
                string query = "SELECT count(*) from Usuarios where usuario=@usuario AND id_Rol=@id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@id_rol", id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool RolUser(string usuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                int id_Rol = 2;
                conn.Open();
                string query = "SELECT count(*) from Usuarios where usuario=@usuario AND id_Rol=@id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@id_rol", id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool ValidarUsuario(Usuarios obj)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario AND clave = @clave";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@clave", obj.Clave);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }


        }



        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
            conexionBD.AbrirConexion(conexion);
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                // Consulta SQL para obtener los nombres de la tabla TablaDatos
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
                    // Verificar si el ítem ya está en el ComboBox antes de agregarlo
                    if (!cbUsuarios.Items.Contains(reader["usuario"].ToString()))
                    {
                        cbUsuarios.Items.Add(reader["usuario"].ToString());
                    }
                }
            }
            
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Crear una nueva instancia del formulario de Bienvenido
            bienvenidosForm = new Bienvenido();
            bienvenidosForm.Show();
            this.Close(); // Ocultar el formulario actual (MainForm)
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolicitarTokenForm solicitarTokenForm = new SolicitarTokenForm();
            solicitarTokenForm.ShowDialog();
        }
    }
}
