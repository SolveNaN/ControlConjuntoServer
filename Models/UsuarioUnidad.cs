using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class UsuarioUnidad
    {
        public int Id { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Unidad? Unidad { get; set; }
        public int UnidadId { get; set; }
    }
}
