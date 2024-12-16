using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Modelo
{
    public class Usuarios
    {
        public int id_Usuario { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Correo { get; set; }
        public int id_Rol { get; set; }
    }
}
