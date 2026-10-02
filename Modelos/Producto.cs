using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Modelos
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int IdUbicacion { get; set; }
    }
}
