using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class ConsultarVentas : Form
    {
        private BindingList<Ventas> ventas = new BindingList<Ventas>();
        public ConsultarVentas()
        {
            InitializeComponent();
            DataGrid_Ventas.DataSource = ventas;
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

        private void RemoveBackgroundImage(ConsultarVentas consultarVentas)
        {
            consultarVentas.BackgroundImage = null;
        }

        private void SetBackgroundColor(ConsultarVentas consultarVentas, Color backgroundColor)
        {
            consultarVentas.BackColor = backgroundColor;
            consultarVentas.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void SetBackgroundImage(ConsultarVentas consultarVentas, Image backgroundImage)
        {
            consultarVentas.BackgroundImage = backgroundImage;
            consultarVentas.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DataGrid_Ventas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];

                int folio = (int)selectedRow.Cells["Folio"].Value;
                int idCliente = (int)selectedRow.Cells["id_Cliente"].Value;
                string fechaAtencion = selectedRow.Cells["Fecha_de_atencion"].Value.ToString();
                string fechaEntrega = selectedRow.Cells["Fecha_de_entrega"].Value.ToString();
                string Total = selectedRow.Cells["Total"].Value.ToString();


                Modificar_Registros_Ventas modificar_Registro = new Modificar_Registros_Ventas(folio, idCliente, fechaAtencion, fechaEntrega, Total);

                if (modificar_Registro.ShowDialog() == DialogResult.OK)
                {

                    DataGrid_Ventas.DataSource = null;
                    DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();

                }

            }
            if(DataGrid_)
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Inicializar el origen de datos del DataGridView
            DataGrid_Ventas.DataSource = null;
            // Obtener la filtración seleccionada en el ComboBox
            string filtracion = cb_filtro.SelectedItem?.ToString(); ;
            // Verificar si se ha seleccionado una opción de filtración

            if (!string.IsNullOrEmpty(filtracion))
            {
                // Obtener el texto de búsqueda del TextBox
                string textoBuscar = txt_buscar.Text;

                switch (filtracion)
                {

                    case "Folio":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFolio(int.Parse(textoBuscar));
                        break;

                    case "id_Cliente":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultaPorCliente(int.Parse(textoBuscar));
                        break;
                    case "Fecha de atención":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFechaAtencion(textoBuscar);
                        break;
                    case "Fecha de entrega":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFechaEntrega(textoBuscar);
                        break;
                    case "Todos":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();
                        break;
                    default:
                        // En caso de que el valor seleccionado no coincida con ninguno de los casos anteriores
                        txt_buscar.Text = ""; // o cualquier otra acción que desees realizar
                        break;
                }

                if (DataGrid_Ventas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    if (DataGrid_Ventas.DataSource is List<Ventas>)
            {
                if (DataGrid_Ventas.SelectedRows.Count > 0)
                {
                    DialogResult confirma = MessageBox.Show("¿Estas seguro de que desea eliminar el registro de venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // Si el origen de datos es una lista de ventas, significa que proviene de VentasLogica
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];
                    // Obtener el Folio de la venta desde la fila seleccionada
                    int folio = (int)selectedRow.Cells["Folio"].Value;


                    //Condicion para validar confirmacion de eliminacion de registro
                    if (confirma == DialogResult.Yes)
                    {
                        // Llamar a la instancia para eliminar la venta usando el Folio
                        bool eliminarVenta = VentasLogica.Instancia.EliminarVenta(folio);
                        bool eliminarDetalles = DetalleVentaLogica.Instancia.EliminarDetalleVenta(folio);
                        if (eliminarVenta && eliminarDetalles)
                        {
                            MessageBox.Show("Venta eliminada correctamente.");
                            // Actualizar el DataGridView después de la eliminación
                            DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();
                        }
                    }
                }


            }
            else if (DataGrid_Ventas.DataSource is List<DetalleVenta>)
            {
                if (DataGrid_Ventas.SelectedRows.Count > 0)
                {

                }
                DialogResult confirma = MessageBox.Show("¿Estas seguro de que desea eliminar los detalles de la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // Si el origen de datos es una lista de detalle de ventas, significa que proviene de DetalleVentasLogica
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];
                // Obtener el Folio  de la venta desde la fila seleccionada
                int folio = (int)selectedRow.Cells["Folio_Venta"].Value;


                //Condicion para validar confirmacion de eliminacion de registro
                if (confirma == DialogResult.Yes)
                {
                    // Llamar al la instancia para eliminar la venta usando el Folio_Venta
                    bool eliminacionExitosa = DetalleVentaLogica.Instancia.EliminarDetalleVenta(folio);

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("Detalles de la Venta eliminada correctamente.");
                        // Actualizar el DataGridView después de la eliminación
                        DataGrid_Ventas.DataSource = DetalleVentaLogica.Instancia.ListarDetalleVenta(folio);
                    }
                }
            }

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una opción en el ComboBox
            if (cb_filtro.SelectedItem.ToString() == "Todos")
            {
                // Bloquear el TextBox
                txt_buscar.Enabled = false;
            }
            else
            {
                txt_buscar.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DataGrid_Ventas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];
                if (selectedRow != null)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = DataGrid_Ventas.SelectedRows[0].Index;
                    // Obtener el Folio seleccionado
                    int folio = (int)DataGrid_Ventas.Rows[rowIndex].Cells[0].Value;

                    DataGrid_Ventas.DataSource = null;
                    DataGrid_Ventas.DataSource = DetalleVentaLogica.Instancia.ListarDetalleVenta(folio);


                }
            }
        }

        private void DataGrid_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
