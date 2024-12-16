using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Modelo
{
    public class DetalleVenta
    {
        public int Folio_Venta {  get; set; }
        public int id_Cliente { get; set; }
        public string? Formato { get; set; }
        public string? Duracion { get; set; }
        public string? Monto { get; set; }

    }
}
