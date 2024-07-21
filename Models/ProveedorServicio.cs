using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class ProveedorServicio
    {
        public int Id { get; set; }
        public Proveedor? Proveedor { get; set; }
        public int ProveedorId { get; set; }
        public Servicio? Servicio { get; set; }  
        public int ServicioId { get; set; }
        public int Estado { get; set; } = 1;// 1→disponible 0→No disponible
    }
}
