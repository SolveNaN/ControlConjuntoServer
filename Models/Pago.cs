using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Pago
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public double Cantidad { get; set; }
        public int Categoria { get; set; }      
        public int Habilitado { get; set; }//0 no, 1 si
        
    }
}
