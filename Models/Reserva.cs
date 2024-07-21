using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Reserva
    {
        public int Id { get; set; }
        public int Horas { get; set; }//Cantidad de horas en las que se va a usar la zona comun
        public AreaComun? AreaComun { get; set; }
        public int AreaComunId { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Estado { get; set; } = 0;//0 →Pendiente 1→Aprobado 2→El usuario Cancela 3→La administracion cancela la reserva        
        public DateTime FechaCambioEstado { get; set; }
    }
}
