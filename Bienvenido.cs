using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using Microsoft.VisualBasic.Logging;
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
    public partial class Bienvenido : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private bool formReiniciado;
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public Bienvenido()
        {
            InitializeComponent();
            formReiniciado = false;
            txt_clave.UseSystemPasswordChar = true;
            txt_clave.PasswordChar = '*';

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

        private void SetBackgroundImage(Bienvenido bienvenido, Image backgroundImage)
        {
            bienvenido.BackgroundImage = backgroundImage;
            bienvenido.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RemoveBackgroundImage(Bienvenido bienvenido)
        {
            bienvenido.BackgroundImage = null;
        }

        private void SetBackgroundColor(Bienvenido bienvenido, Color backgroundColor)
        {
            bienvenido.BackColor = backgroundColor;
        }



        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_clave.Text) && string.IsNullOrWhiteSpace(txt_usuario.Text))
            {

                MessageBox.Show("Por favor ingrese un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txt_clave.Text))
            {
                MessageBox.Show("Por favor ingrese un una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();

                return;
            }


            int idRol = 1;
            Usuarios admin = new Usuarios()
            {
                Usuario = txt_usuario.Text,
                Clave   = txt_clave.Text,
                Correo  = txt_email.Text,
                id_Rol  = idRol,
            };

            if (UsuariosLogica.Instancia.VerificarAdminExistente(admin))
            {
                Clave_Administrador clave_Administrador = new Clave_Administrador();
                clave_Administrador.ShowDialog();

            }

            else
            {
                bool respuesta = UsuariosLogica.Instancia.IngresarNuevoAdmin(admin);

                if (respuesta)
                {
                    MessageBox.Show("¡Usuario creado correctamente!,inicie sesión", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_usuario.Text = "";
                    txt_email.Text = "";
                    txt_clave.Text = "";
                    LimpiarFormulario();
                }
            }

        }

        private void LimpiarFormulario()
        {
            LimpiarControles(this);
        }

        private void LimpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private Autenticacion loginForm;
        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario de autenticación ya está abierto
            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.BringToFront(); // Traer la instancia existente al frente
                return;
            }
            // Crear una nueva instancia del formulario de autenticación
            loginForm = new Autenticacion();
            loginForm.Show();
            this.Hide(); // Ocultar el formulario actual
            this.Dispose(); //Liberar todos los recursos
        }



        private void Bienvenido_Load(object sender, EventArgs e)
        {

            conexionBD.AbrirConexion(conexion);

        }
        public TextBox TextBox_Usuario
        {
            get { return txt_usuario; }
        }
        public TextBox Textbox_Clave
        {
            get { return txt_clave; }
        }

        public TextBox Textbox_Correo
        {
            get { return txt_email; }
        }

    }
}
