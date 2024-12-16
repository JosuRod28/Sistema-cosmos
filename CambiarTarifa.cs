using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COSMOSCOM
{
    public partial class CambiarTarifa : Form
    {

        // Propiedad estática para almacenar el precio del formato
        public static int PrecioFormato { get; set; }
        public CambiarTarifa()
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
        }

        private void SetBackgroundImage(CambiarTarifa cambiarTarifa, Image backgroundImage)
        {
            cambiarTarifa.BackgroundImage = backgroundImage;
            cambiarTarifa.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Intentar convertir el texto del TextBox a un entero
            if (int.TryParse(txt_Precio.Text, out int precio))
            {
                PrecioFormato = precio;

                MessageBox.Show("Precio guardado correctamente.");
                this.Close();

                Properties.Settings.Default.Save();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CambiarTarifa_Load(object sender, EventArgs e)
        {

        }
    }
}
