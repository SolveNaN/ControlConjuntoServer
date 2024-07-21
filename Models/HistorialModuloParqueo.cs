using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class HistorialModuloParqueo
    {
        public int Id { get; set; }
        public int Estado { get; set; }// 0→Que en ese modulo no hay ningun carro parqueado 1→Que en la hora actual hay un carro en ese modulo
        public ModuloParqueo? ModuloParqueo { get; set; }
        public int ModuloParqueoId { get; set; }
        public DateTime Fecha { get; set; }= DateTime.Now;//fecha en la cual entra o sale
        public string Placa { get; set; } = string.Empty;//Placas del auto que entra o sale a ese modulo
        public string Observacion { get; set; } = string.Empty;
    }
}
