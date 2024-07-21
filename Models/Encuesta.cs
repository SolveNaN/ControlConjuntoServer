using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Encuesta
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Opcion1 { get; set; } = string.Empty;
        public string Opcion2 { get; set; } = string.Empty;
        public string Opcion3 { get; set; } = string.Empty;
        public string Opcion4 { get; set; } = string.Empty;
        public string Opcion5 { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;//1 →Habilitado 0→Finalizada (Aparece en pantalla pero no se puede enviar respuestas) -1 →Deshabilitada (No aparece en pantalla)
        public int UploadResultId { get; set; }//para referenciar el archivo de imagen

    }
}
