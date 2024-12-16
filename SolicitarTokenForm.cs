using COSMOSCOM.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class SolicitarTokenForm : Form
    {
        public SolicitarTokenForm()
        {
            InitializeComponent();
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

        private void SetBackgroundColor(SolicitarTokenForm solicitarTokenForm, Color backgroundColor)
        {
            solicitarTokenForm.BackColor = backgroundColor;
            solicitarTokenForm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RemoveBackgroundImage(SolicitarTokenForm solicitarTokenForm)
        {
            solicitarTokenForm.BackgroundImage = null;
        }

        private void SetBackgroundImage(SolicitarTokenForm solicitarTokenForm, Image backgroundImage)
        {
            solicitarTokenForm.BackgroundImage = backgroundImage;
            solicitarTokenForm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public TextBox Text_Email
        {
            get { return txt_email; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            if (!string.IsNullOrEmpty(email))
            {
                GenerarCodigo enviarEmail = new GenerarCodigo();
                enviarEmail.Generar_y_MandarClave(email);
                return;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico.");
            }
        }

        private void btn_verClave_Click(object sender, EventArgs e)
        {
            int idUsuario = RestablecerClave.Instancia.ObtenerUsuario(txt_email.Text);
            string claveReset = txt_ClaveReset.Text;

            if (!string.IsNullOrEmpty(claveReset))
            {
                GenerarCodigo reset = new GenerarCodigo();
                bool resp = reset.VerificarClave(claveReset);
                if (resp)
                {
                    
                    ResetPassword resetPassword = new ResetPassword(idUsuario);
                    resetPassword.ShowDialog();
                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El codigo proporcionado no es correcto o ya ha caducado intenta de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor escriba la clave que se mando por correo para poder restablecer su contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitarTokenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
