using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Unidad
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Torre? Torre { get; set; }
        public int TorreId { get; set; }
        public string Telefono { get; set; } = string.Empty;       
        public string Categoria { get; set; } = string.Empty;//vip, general, derechos especiales
        public string Tipo { get; set; } = string.Empty;//Apartameno, penhouse, apartaestudio
    }
}
