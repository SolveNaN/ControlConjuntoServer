using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class UsuarioPideServicio
    {
        public int Id { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ProveedorServicio? ProveedorServicio { get; set; }
        public int ProveedorServicioId { get; set; }
        public DateTime Fecha { get; set; }
        public double Valor {  get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Estado { get; set; }//0→En proceso 1→En camino 2→Cancelado
        public int TipoPago { get; set; } = 0;//0 →Efectivo 1→Sumar al pago administracion
    }
}
