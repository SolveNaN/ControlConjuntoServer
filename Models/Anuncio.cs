using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int UploadResultId { get; set; }//Es el identificador con el que busca el archivo
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaFinal { get; set; } = DateTime.Now;
        public int Habilitado { get; set; }
        public int MeGusta { get; set; }
        public int NoMeGusta { get; set; }
        public int UsuarioId { get; set; }//Es el usuario administrador quien hace el anuncio
        
    }
}
