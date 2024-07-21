using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Torre
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Conjunto? Conjunto { get; set; }
        public int ConjuntoId { get; set; }
    }
}
