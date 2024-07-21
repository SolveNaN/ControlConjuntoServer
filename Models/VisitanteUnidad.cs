using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class VisitanteUnidad
    {
        public int Id { get; set; }
        public Unidad? Unidad { get; set; }
        public int UnidadId { get; set; }
        public Visitante? Visitante { get; set; }
        public int VisitanteId { get; set; }
        public DateTime HoraIngreso { get; set; }= DateTime.Now;
        public DateTime HoraSalida {  get; set; }
        public string Observacion { get; set; }=string.Empty;
    }
}
