using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Modelos
{
    public class Kardex
    {
        public string IdMovimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public string IdLote { get; set; }
        public string UsuarioResponsable { get; set; }
    }
}
