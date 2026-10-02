using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Datos
{
    public class ConexionBD
    {
        
            private readonly string cadenaConexion = "Server=LAPTOP-9AB6BH7V ;Database=SIGEV;Trusted_Connection=True;";

            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(cadenaConexion);
            }
        }
}
