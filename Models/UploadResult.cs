using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class UploadResult
    {
        public int Id { get; set; }
        public string NombreCorto { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Formato { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editorial { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
        public int Prioridad { get; set; } = 3;
        public int Disponible { get; set; } = 1;
        public string StoredFileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
