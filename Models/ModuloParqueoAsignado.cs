using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class ModuloParqueoAsignado
    {
        public int Id { get; set; }
        public ModuloParqueo? ModuloParqueo { get; set; }
        public int ModuloParqueoId { get; set; }
        public Unidad? Unidad { get; set; }
        public int UnidadId { get; set; }
    }
}
