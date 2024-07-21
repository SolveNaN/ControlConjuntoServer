using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class ReporteAdmin
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Folio { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Proveedor { get; set; } = string.Empty;
        public string Responsable { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;//Ingreso egreso
        public string Articulo { get; set; } = string.Empty;
        public string Referencia { get; set; } = string.Empty;
        public double Valor { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string UsuarioId { get; set; } = string.Empty;//Es el id del usuario administrador que genera este registro
    }
}
