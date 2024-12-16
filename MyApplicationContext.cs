using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM
{
    public class MyApplicationContext : ApplicationContext
    {
        private Bienvenido bienvenidoForm;

        public MyApplicationContext()
        {
            // Inicia la lógica para determinar qué formulario mostrar
            // Ejemplo: Mostrar el formulario de Bienvenidos al inicio
            MostrarFormularioBienvenidos();
        }

        private void MostrarFormularioBienvenidos()
        {
            bienvenidoForm = new Bienvenido();
            bienvenidoForm.FormClosed += OnFormClosed;
            bienvenidoForm.Show();
        }

        private void OnFormClosed(object? sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}
