using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
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
    public partial class ResetPassword : Form
    {
        private int idUsuario;
        public ResetPassword(int idUusario)
        {
            InitializeComponent();
            this.idUsuario = idUusario;
            ApplyBgImage();
            txt_NuevaClave.PasswordChar = '*';
            txt_ConfirmarClave.PasswordChar = '*';
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

        private void RemoveBackgroundImage(ResetPassword resetPassword)
        {
            resetPassword.BackgroundImage = null;
        }

        private void SetBackgroundColor(ResetPassword resetPassword, Color backgroundColor)
        {
            resetPassword.BackColor = backgroundColor;
            resetPassword.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SetBackgroundImage(ResetPassword resetPassword, Image backgroundImage)
        {
            resetPassword.BackgroundImage = backgroundImage;
            resetPassword.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_restablecer_Click(object sender, EventArgs e)
        {
            string? nuevaClave = txt_NuevaClave.Text;

            if (ValidarCampos())
            {
                //Llamar a la consulta
                RestablecerClave resetPassword = new RestablecerClave();
                resetPassword.ActualizarPassword(nuevaClave, idUsuario);

            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txt_NuevaClave.Text))
            {
                MessageBox.Show("Por favor ingrese la nueva contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NuevaClave.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_ConfirmarClave.Text))
            {
                MessageBox.Show("Por favor de confirmar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NuevaClave.Focus();
                return false;

            }
            return true;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
