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
    public partial class AdministraUsuarios : Form
    {
        public AdministraUsuarios()
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

        private void RemoveBackgroundImage(AdministraUsuarios administraUsuarios)
        {
            administraUsuarios.BackgroundImage = null;
        }

        private void SetBackgroundColor(AdministraUsuarios administraUsuarios, Color backgroundColor)
        {
            administraUsuarios.BackColor = backgroundColor;
            administraUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SetBackgroundImage(AdministraUsuarios administraUsuarios, Image backgroundImage)
        {
            administraUsuarios.BackgroundImage = backgroundImage;
            administraUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void AdministraUsuarios_Load(object sender, EventArgs e)
        {
            dGVUsuarios.DataSource = null;
            dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();
            dGVUsuarios.DefaultCellStyle.ForeColor = Color.MediumBlue;



        }

        private void dGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Estas seguro de que desea eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (dGVUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dGVUsuarios.SelectedRows[0];
                    if (selectedRow != null)
                    {
                        // Obtener el índice de la fila seleccionada
                        int rowIndex = dGVUsuarios.SelectedRows[0].Index;

                        // Obtener el objeto Cliente correspondiente a la fila seleccionada
                        Usuarios usuarioSeleccionado = (Usuarios)dGVUsuarios.Rows[rowIndex].DataBoundItem;

                        // Obtener el ID del cliente seleccionado
                        int id_usuario = usuarioSeleccionado.id_Usuario;


                        //Condicion para validar confirmacion de eliminacion de registro
                        if (confirma == DialogResult.Yes)
                        {
                            // Eliminar el registro de la base de datos
                            bool deleteRegistro = UsuariosLogica.Instancia.Eliminar(id_usuario);
                            //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación
                            if (deleteRegistro)
                            {

                                // Remover la fila de la fuente de datos
                                UsuariosLogica.Instancia.ListUsuarios().Remove(usuarioSeleccionado);
                                // Actualizar el DataGridView
                                dGVUsuarios.DataSource = null;
                                dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();

                                //Mensaje de confirmación

                                MessageBox.Show("Registro eliminado", "Confirmación", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                    }


                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVUsuarios.SelectedCells.Count > 0)
                {

                    DataGridViewRow selectedRow = dGVUsuarios.SelectedRows[0];
                    int idUsuario = (int)selectedRow.Cells["id_usuario"].Value;
                    string? usuario =selectedRow.Cells["usuario"].Value.ToString();
                    string? clave = selectedRow.Cells["clave"].Value.ToString();
                    string? correo = selectedRow.Cells["correo"].Value.ToString();
                    string? id_Rol = selectedRow.Cells["id_Rol"].Value.ToString();
                    
                    Modificar_Usuarios modificar_Usuarios = new Modificar_Usuarios(idUsuario,usuario,clave,correo,id_Rol);

                    if (modificar_Usuarios.ShowDialog() == DialogResult.OK)
                    {

                        dGVUsuarios.DataSource = null;
                        dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoUsuario agregarUsuarioNuevo = new NuevoUsuario(this);
            agregarUsuarioNuevo.ShowDialog();
           
        }
        public void ActualizarDataGridView()
        {
            dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
