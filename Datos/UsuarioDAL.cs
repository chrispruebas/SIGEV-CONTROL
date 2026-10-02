using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Datos
{
    public class UsuarioDAL
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public Usuario ValidarLogin(string id, string pass)
        {
            Usuario user = null;
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "SELECT id, nombre, cargo, contrasena FROM usuarios WHERE id = @id AND contrasena = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pass", pass);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Usuario
                        {
                            Id = reader["id"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Cargo = reader["cargo"].ToString(),
                            Contrasena = reader["contrasena"].ToString()
                        };
                    }
                }
            }
            return user;
        }
    }
}
