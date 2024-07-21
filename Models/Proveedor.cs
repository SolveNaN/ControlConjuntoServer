using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=string.Empty;
        public string Descripcion { get; set; }=string.Empty;
        public string Telefono { get; set; }=string.Empty;
        public string Direccion { get; set; }=string.Empty;
        public int UploadResultId { get; set; }//Si hay archivo adjunto
    }
}
