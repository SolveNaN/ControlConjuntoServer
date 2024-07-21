using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class ModuloParqueo
    {
        public int Id { get; set; } 
        public int Numero { get; set; } //El orden respecto a otros modulos, puede ser autoincremental
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Parqueadero? Parqueadero { get; set; }
        public int ParqueaderoId { get; set; }
        public int Estado { get; set; } = 0;//0 →No asignado, 1→Asignado -1→deshabilitado
    }
}
