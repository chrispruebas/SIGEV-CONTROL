using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Modelos
{
    public class Usuario
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; } // Aquí se guarda "Administrador" o "Almacenero"
        public string Contrasena { get; set; }

        // Métodos auxiliares dentro de la misma clase para consultar el rol
        public bool EsAdministrador()
        {
            return Cargo != null && Cargo.Equals("Administrador", System.StringComparison.OrdinalIgnoreCase);
        }

        public bool EsAlmacenero()
        {
            return Cargo != null && Cargo.Equals("Almacenero", System.StringComparison.OrdinalIgnoreCase);
        }
    }
}

 