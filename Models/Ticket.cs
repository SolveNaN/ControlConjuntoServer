using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;        
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Estado { get; set; }//-1 es pendiente,0 en proceso, 1 Resuelto
        public string RespuestaAdministracion { get; set; } = string.Empty;
        public DateTime FechaRespuesta { get; set; } = DateTime.Now;
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public int UploadResultId { get; set; }//Este es opcional en caso de que la persona adjunte archivo
    }
}
