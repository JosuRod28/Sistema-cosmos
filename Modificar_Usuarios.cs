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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace COSMOSCOM
{
    public partial class Modificar_Usuarios : Form
    {

        private int idUsuario;
        public Modificar_Usuarios(int idUsuario, string usuario, string clave,string correo, string id_Rol)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            txt_id_usuario.Text = idUsuario.ToString();
            txt_Usuario.Text = usuario;
            txt_passwd.Text = clave;
            txt_correo.Text = correo;
            txt_Rol.Text = id_Rol;

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

        private void RemoveBackgroundImage(Modificar_Usuarios modificar_Usuarios)
        {
            modificar_Usuarios.BackgroundImage = null;

        }

        private void SetBackgroundColor(Modificar_Usuarios modificar_Usuarios, Color backgroundColor)
        {
            modificar_Usuarios.BackColor = backgroundColor;
            modificar_Usuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SetBackgroundImage(Modificar_Usuarios modificar_Usuarios, Image backgroundImage)
        {
            modificar_Usuarios.BackgroundImage = backgroundImage;
            modificar_Usuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Modificar_Usuarios_Load(object sender, EventArgs e)
        {
            txt_id_usuario.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos modificados

                string nuevoUsuario = txt_Usuario.Text;
                string nuevaClave = txt_passwd.Text;
                string nuevoRol = txt_Rol.Text;

                // Construir la consulta de actualización
                string consulta = $"UPDATE Usuarios SET usuario = '{nuevoUsuario}', clave = '{nuevaClave}', id_Rol = '{nuevoRol}' WHERE id_usuario = {idUsuario}";

                // Actualizar los datos en la base de datos
                if (UsuariosLogica.Instancia.ActualizarUsuario(consulta))
                {
                    MessageBox.Show("Datos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_passwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
