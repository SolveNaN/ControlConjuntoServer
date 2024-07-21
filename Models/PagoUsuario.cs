using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class PagoUsuario
    {
        public int Id { get; set; }
        public Pago? Pago { get; set; }
        public int PagoId { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public int FuePagado { get; set; } = 0;//0 NO,1 Si
    }
}
