using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Modelos
{
    public class Ubicacion
    {
        public int IdUbicacion { get; set; }
        public string Estante { get; set; }
        public string Fila { get; set; }
        public int Columna { get; set; }

    }
}
