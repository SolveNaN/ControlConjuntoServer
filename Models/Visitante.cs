using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NoIdentidad { get; set; } = string.Empty;
        public string Obseracion { get; set; } = string.Empty;
        public int UploadResultId { get; set; }//Para la foto de la persona
    }
}
