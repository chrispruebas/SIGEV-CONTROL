using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Modelos
{
    public class Lote
    {
        public string IdLote { get; set; }
        public string IdProducto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
    }
}
