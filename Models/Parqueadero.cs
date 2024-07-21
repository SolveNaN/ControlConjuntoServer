using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoServer.Shared
{
    public class Parqueadero
    {
        public int Id { get; set; }
        public int Numero { get; set; }//Corresponde al orden que lleva en comparacion a otros parqueaderos
        public int Capacidad { get; set; }//Cantidad de modulos del parqueaderop
        public int Disponible { get; set; } = 1;//0 →No disponible 1→Habilitado
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Torre? Torre { get; set; }
        public int TorreId { get; set; }

    }
}
