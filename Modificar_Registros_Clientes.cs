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
    public partial class Modificar_Registros_Clientes : Form
    {
        private int idCliente;
        public Modificar_Registros_Clientes(int idCliente, string nombre, string apellido_p, string apellido_m, string telefono1, string telefono2)
        {
            InitializeComponent();
            //Mostrar los datos del cliente en los campos de textbox
            this.idCliente = idCliente;
            txt_id_Cliente.Text = idCliente.ToString();
            txt_Nombre.Text = nombre;
            txt_Apellido_P.Text = apellido_p;
            txt_Apellido_M.Text = apellido_m;
            txt_Telefono1.Text = telefono1;
            txt_Telefono2.Text = telefono2;

            //Lamar el metodo para aplicar el fondo
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

        private void RemoveBackgroundImage(Modificar_Registros_Clientes modificar_Registros_Clientes)
        {
            modificar_Registros_Clientes.BackgroundImage= null;
        }

        private void SetBackgroundColor(Modificar_Registros_Clientes modificar_Registros_Clientes, Color backgroundColor)
        {
            modificar_Registros_Clientes.BackColor = backgroundColor;
            modificar_Registros_Clientes.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SetBackgroundImage(Modificar_Registros_Clientes modificar_Registros_Clientes, Image backgroundImage)
        {
            modificar_Registros_Clientes.BackgroundImage = backgroundImage;
            modificar_Registros_Clientes.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos modificados
                string nuevoNombre = txt_Nombre.Text;
                string nuevoApellidoP = txt_Apellido_P.Text;
                string nuevoApellidoM = txt_Apellido_M.Text;
                string nuevoTelefono1 = txt_Telefono1.Text;
                string nuevoTelefono2 = txt_Telefono2.Text;
                // Construir la consulta de actualización
                string consulta = $"UPDATE Clientes SET Nombre = '{nuevoNombre}', Apellido_P = '{nuevoApellidoP}', Apellido_M = '{nuevoApellidoM}', Telefono1 = '{nuevoTelefono1}', Telefono2='{nuevoTelefono2}' WHERE id_Cliente = {idCliente}";

                // Actualizar los datos en la base de datos
                if (ClientesLogica.Instancia.ActualizarCliente(consulta))
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

        private void Modificar_Registros_Clientes_Load(object sender, EventArgs e)
        {
            txt_id_Cliente.ReadOnly = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
