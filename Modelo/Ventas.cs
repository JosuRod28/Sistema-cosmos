using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Modelo
{
    public class Ventas
    {
        public int Folio {  get; set; }
        public int id_Cliente { get; set; }
        public string? Fecha_de_atencion { get; set; }
        public string? Fecha_de_entrega { get; set; }
        public string? Total { get; set; }

    }
}
