using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class EncuestaUsuario
    {
        public int Id { get; set; }
        public int RespuestaOpcion1 { get; set; } = 0;
        public int RespuestaOpcion2 { get; set; } = 0;
        public int RespuestaOpcion3 { get; set; } = 0;
        public int RespuestaOpcion4 { get; set; } = 0;
        public int RespuestaOpcion5 { get; set; } = 0;
        public string Observaciones { get; set; } = string.Empty;
        public DateTime FechaRespuesta { get; set; } = DateTime.Now;
        public Encuesta? Encuesta { get; set; }
        public int EncuestaId { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
