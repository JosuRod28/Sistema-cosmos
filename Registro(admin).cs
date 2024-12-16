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
using COSMOSCOM.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Forms = System.Windows.Forms;
using System.Configuration;



namespace COSMOSCOM
{
    public partial class Registro_admin_ : Form
    {


        private string folioActual = "";
        private string montoActual = CambiarTarifa.PrecioFormato.ToString();
        private bool seAgregoFila;
        ConexionBD conexionBD = new ConexionBD();
        public Registro_admin_()
        {

            InitializeComponent();
            // El valor de la duracion se cambian con el componente numericUpDown
            nUpDown.ValueChanged += UpDown_ValueChanged;
            txt_Monto.Text = CambiarTarifa.PrecioFormato.ToString();

            // Asociar el método de los textbox con el evento KeyPress del TextBox
            txt_Nombre.KeyPress += new KeyPressEventHandler(txt_Nombre_KeyPress);
            txt_Apellido_P.KeyPress += new KeyPressEventHandler(txt_Apellido_P_KeyPress);
            txt_Apellido_M.KeyPress += new KeyPressEventHandler(txt_Apellido_M_KeyPress);
            txt_Telefono1.KeyPress += new KeyPressEventHandler(txt_Telefono1_KeyPress);
            txt_Telefono2.KeyPress += new KeyPressEventHandler(txt_Telefono2_KeyPress);
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

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {

            // Obtener el valor actual del NumericUpDown
            int valor = (int)nUpDown.Value;
            int precio = CambiarTarifa.PrecioFormato;
            // Calcular el monto utilizando el precio y el valor del NumericUpDown
            int monto = (int)(valor * precio / 120);
            // Asignar el monto calculado al TextBox txt_Monto
            txt_Monto.Text = monto.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Autenticacion loginForm;
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmación para salir del sistema
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {

                folioActual = txt_Folio.Text;
                // Actualiza el TextBox con el último valor ingresado
                txt_Folio.Text = folioActual;
                txt_Monto.Text = montoActual;

                Properties.Settings.Default.FolioActual = folioActual;
                Properties.Settings.Default.Save();
                loginForm = new Autenticacion();
                loginForm.Show();
                this.Hide();
            }

        }



        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int folio;
                int total;

                // Validar y convertir el texto a un entero para el Folio
                if (string.IsNullOrEmpty(txt_Folio.Text) || !int.TryParse(txt_Folio.Text, out folio))
                {
                    MessageBox.Show("Por favor, ingresa un número de folio válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar y convertir el texto a un decimal para el Total
                if (string.IsNullOrEmpty(txt_Total.Text) || !int.TryParse(txt_Total.Text, out total))
                {
                    MessageBox.Show("Por favor, ingresa un total válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que las fechas no estén vacías
                if (string.IsNullOrEmpty(dtp_Fecha_atencion.Text) || string.IsNullOrEmpty(dtp_Fecha_entrega.Text))
                {
                    MessageBox.Show("Por favor, ingresa fechas válidas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que las fechas no estén vacías
                if (string.IsNullOrEmpty(dtp_Fecha_atencion.Text) || string.IsNullOrEmpty(dtp_Fecha_entrega.Text))
                {
                    MessageBox.Show("Por favor, ingresa fechas válidas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Creacion del objeto Clientes que hace referencia a la clase Clientes
                Clientes objetoClientes = new Clientes()
                {
                    //Se inicializan las propiedades con los valores ingresados en os campos de texto.
                    id_Cliente = ClientesLogica.Instancia.idCliente(),
                    Nombre = txt_Nombre.Text,
                    Apellido_P = txt_Apellido_P.Text,
                    Apellido_M = txt_Apellido_M.Text,
                    Telefono1 = txt_Telefono1.Text,
                    Telefono2 = txt_Telefono2.Text,

                };

                Ventas objetoVentas = new Ventas()
                {
                    //Se inicializan las propiedades con los valores ingresados en los campos de texto.

                    Folio = folio,
                    id_Cliente = VentasLogica.Instancia.idCliente(),
                    Fecha_de_atencion = dtp_Fecha_atencion.Text,
                    Fecha_de_entrega = dtp_Fecha_entrega.Text,
                    Total = total.ToString(),

                };



                if (ValidarCampos())
                {
                    int folioVenta = int.Parse(txt_Folio.Text);


                    List<DetalleVenta> detalleVentas = new List<DetalleVenta>();
                    foreach (DataGridViewRow fila in dgv_Formatos.Rows)
                    {
                        // Verificar si la fila es una fila nueva
                        if (!fila.IsNewRow)
                        {
                            DetalleVenta detalle = new DetalleVenta();
                            detalle.Formato = fila.Cells["Formato"].Value.ToString();
                            detalle.Duracion = fila.Cells["Duracion"].Value.ToString();
                            detalle.Monto = fila.Cells["Monto"].Value.ToString();
                            detalleVentas.Add(detalle);

                        }
                    }

                    int.TryParse(txt_Folio.Text, out int numFolio); //Variable para actualizar el número de folio

                    // Llamamos al metodo Guardar del clase ClientesLogica y lo  aginamos a una variable de tipo boleano.
                    //Se utiliza la propiedad Instancia de la clase ClientesLogica.
                    bool resClientes = ClientesLogica.Instancia.Guardar(objetoClientes);
                    //Se utiliza la propiedad Instancia de la clase VentasLogica.
                    bool resVentas = VentasLogica.Instancia.Guardar(objetoVentas);
                    //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación

                    bool resDetalle = DetalleVentaLogica.Instancia.InsertarDetalleVenta(folioVenta, detalleVentas);


                    if (resClientes)
                    {
                        MessageBox.Show("Registro de clientes guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    if (resVentas)
                    {
                        MessageBox.Show("Registro de ventas guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    if (resDetalle)
                    {
                        MessageBox.Show("Detalles de venta insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar detalles de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    numFolio++;

                    txt_Folio.Text = numFolio.ToString();

                    LimpiarDatos();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }


        }

        private bool ValidarCampos()
        {

            Clientes idCliente = new Clientes();
            Ventas folio = new Ventas();

            folio.Folio = int.Parse(txt_Folio.Text);
            idCliente.id_Cliente = ClientesLogica.Instancia.idCliente();
            folio.id_Cliente = VentasLogica.Instancia.idCliente();

            bool ConsultaIdClientes = ClientesLogica.Instancia.ver_idCliente(idCliente.id_Cliente);
            bool ConsultaFolio = VentasLogica.Instancia.ver_Folio(folio.Folio);
            bool ConsultaFKClientes = VentasLogica.Instancia.ver_FKCliente(folio.id_Cliente);
            // Validar que los campos de texto no estén vacíos


            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Apellido_P.Text))
            {
                MessageBox.Show("Se necesita al menos un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Telefono1.Text))
            {
                MessageBox.Show("Se necesita al menos un número telefónico ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_Telefono1.TextLength != 10)
            {
                MessageBox.Show("El número de teléfono requiere de máximo 10 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txt_Telefono2.Text) && txt_Telefono2.TextLength < 10)
            {
                MessageBox.Show("Por favor, complete el segundo número de teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            //Verificar si existen fechas de entrega ya  registradas

            if (VentasLogica.Instancia.BuscarFechasEntrega(dtp_Fecha_entrega.Text))
            {
                MessageBox.Show($"Ya existe un registro para la fecha de entrega {dtp_Fecha_entrega.Value.ToShortDateString()}, selecciona otra fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si alguna celda en alguna fila del DataGridView tiene un valor


            // Si no se encontraron elementos agregados a la tabla de formatos
            if (!ElementosAgregados(dgv_Formatos))
            {
                MessageBox.Show("Por favor, agregue elementos a la tabla de formatos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            if (ConsultaIdClientes)
            {
                MessageBox.Show($"Ya existe un registro con el mismo número de cliente{idCliente.id_Cliente} , por favor borre el cliente que se encuentra actualmente registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (ConsultaFolio)
            {
                MessageBox.Show($"Ya existe un registro con el número de folio {txt_Folio.Text}, por favor borre la venta relacionado a este folio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ConsultaFKClientes)
            {
                MessageBox.Show($"Ya existe un registro con el número de cliente {folio.id_Cliente}, por favor borre el cliente asociado a esta venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private bool ElementosAgregados(DataGridView dataGridView)
        {
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    // Verificar si la celda no está vacía
                    if (celda.Value != null && !string.IsNullOrWhiteSpace(celda.Value.ToString()))
                    {
                        // Si se encuentra algún valor, retornar verdadero y salir de la función
                        return true;
                    }
                }
            }
            return false;
        }

        private void LimpiarDatos()
        {
            txt_Nombre.Text = "";
            txt_Apellido_P.Text = "";
            txt_Apellido_M.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono2.Text = "";
            dgv_Formatos.Rows.Clear();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Muestra un cuadro de dialogo que pregunta si deseamos cancelar el registro
            DialogResult confirma = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Condicion que verifica si la respuesta fue confirmada si se cancela.
            if (confirma == DialogResult.Yes)
            {
                //Si se confirma la condicion se limpian los campos y se eliminan las filas del DataGridView
                LimpiarDatos();

            }



        }

        private void cb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // Cargar el último valor ingresado desde la configuración de la aplicación
            folioActual = Properties.Settings.Default.FolioActual;
            montoActual = Properties.Settings.Default.MontoActual;
            // Mostrar el último valor ingresado en el TextBox
            txt_Folio.Text = folioActual;
            folioActual = txt_Folio.Text;
            txt_Monto.Text = montoActual;
            dgv_Formatos.DefaultCellStyle.ForeColor = Color.MediumBlue;
            CargarFormatos();
            LimpiarDataGridView();

        }

        private void LimpiarDataGridView()
        {
            dgv_Formatos.Rows.Clear();
        }

        private void CargarFormatos()
        {

            // Asignar la lista de formatos al ComboBox
            cb_Formatos.DataSource = Formatos.Instancia.ObtenerFormatos();

            // Especificar la propiedad que se mostrará en el ComboBox
            cb_Formatos.DisplayMember = "TipoFormato";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un ítem en el ComboBox
            if (cb_Formatos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un formato antes de agregar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si hay un valor  en el campo de monto
            if (string.IsNullOrWhiteSpace(txt_Monto.Text))
            {
                MessageBox.Show("Por favor seleccione el monto inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Captura de los datos ingresados de en los campos 
            string formato = cb_Formatos.Text;
            string duracion = nUpDown.Value.ToString();
            string monto = txt_Monto.Text;

            //Estos valores capturados se agregan como una nueva fila al DataGridView.
            dgv_Formatos.Rows.Add(formato, duracion, monto);

            //Se itera sobre todas las filas del DataGridView para calcular la suma de los montos de las filas que tienen un valor en la tercera columna. 

            int total = 0; //Inicializar el total en 0

            for (int i = 0; i < dgv_Formatos.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = dgv_Formatos.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null) //se verifica si la fila actual no es una fila nueva
                {
                    total += Convert.ToInt32(fila.Cells[2].Value); //Se itera los valores sumados y se guardan en la variable total
                }
            }
            txt_Total.Text = total.ToString(); //La suma se cuarda en el campo del total

            //Se actualiza el número de formatos mostrado en un control de etiqueta, excluyendo la última fila.
            int numFormatos = dgv_Formatos.Rows.Count - 1;
            label15.Text = numFormatos.ToString();

            // Establece la bandera como verdadera para indicar que se agregó un formato
            seAgregoFila = true;
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgv_Formatos.IsCurrentCellInEditMode)
                {
                    dgv_Formatos.EndEdit();

                }
                if (dgv_Formatos.CurrentRow != null && !dgv_Formatos.CurrentRow.IsNewRow)
                {
                    dgv_Formatos.Rows.RemoveAt(dgv_Formatos.CurrentRow.Index);
                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("No hay una fila seleccionada o la fila es nueva.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ActualizarTotal()
        {
            int total = 0;
            for (int i = 0; i < dgv_Formatos.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = dgv_Formatos.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null)
                {
                    total += Convert.ToInt32(fila.Cells[2].Value);
                }
            }

            txt_Total.Text = total.ToString();
            int numFormatos = dgv_Formatos.Rows.Count - 1;
            label15.Text = numFormatos.ToString();
        }

        private void btn_ConsultarC_Click(object sender, EventArgs e)
        {
            ConsultarClientes formularioExistente = Application.OpenForms.OfType<ConsultarClientes>().FirstOrDefault();


            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();

            }
            else
            {
                ConsultarClientes ventana = new ConsultarClientes();
                ventana.ShowDialog();
            }

        }

        private void btn_ConsultarV_Click(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Resize(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void modificarUsuarioYContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministraUsuarios administraUsuarios = new AdministraUsuarios();

            administraUsuarios.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cambiarTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarTarifa form = new CambiarTarifa();
            form.ShowDialog();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla pulsada es una letra o una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla no es una letra y no es una tecla de control, se ignora
                e.Handled = true;
            }
        }

        private void txt_Apellido_P_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Apellido_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla pulsada es una letra o una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla no es una letra y no es una tecla de control, se ignora
                e.Handled = true;
            }
        }

        private void txt_Apellido_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla pulsada es una letra o una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla no es una letra y no es una tecla de control, se ignora
                e.Handled = true;
            }
        }

        private void txt_Telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla pulsada es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número y no es una tecla de control, se ignora
                e.Handled = true;
            }
        }

        private void txt_Telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla pulsada es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número y no es una tecla de control, se ignora
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultarVentas formularioExistente = Application.OpenForms.OfType<ConsultarVentas>().FirstOrDefault();


            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();

            }
            else
            {
                ConsultarVentas ventana = new ConsultarVentas();
                ventana.ShowDialog();
            }
        }

        private void camniarTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    Properties.Settings.Default.BackgroundColor = selectedColor;
                    Properties.Settings.Default.BackgroundImagePath = string.Empty; // Eliminar la imagen de fondo
                    Properties.Settings.Default.Save();

                    // Aplicar el color de fondo al formulario actual
                    SetBackgroundColor(this, selectedColor);
                    RemoveBackgroundImage(this);
                }
            }
        }

        private void RemoveBackgroundImage(Form form)
        {
            form.BackgroundImage = null;
        }

        private void SetBackgroundColor(Form form, Color color)
        {
            form.BackColor = color;
            form.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void cambiarImagenDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccione una imagen para el fondo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    Properties.Settings.Default.BackgroundImagePath = selectedFilePath;
                    Properties.Settings.Default.Save();


                    Image backgroundImage = Image.FromFile(selectedFilePath);
                    // Aplicar el fondo al formulario actual
                    SetBackgroundImage(this, backgroundImage);

                }
            }
        }

        private void SetBackgroundImage(Form form, Image backgroundImage)
        {

            form.BackgroundImage = backgroundImage;
            form.BackgroundImageLayout = ImageLayout.Stretch;
        }


    }
}
