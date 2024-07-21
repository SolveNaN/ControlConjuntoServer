using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }=string.Empty;
        public Anuncio? Anuncio { get; set; }
        public int AnuncioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
