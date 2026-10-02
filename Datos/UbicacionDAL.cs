using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIGEV.Datos
{
    public class UbicacionDAL
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Ubicacion> Listar()
        {
            List<Ubicacion> lista = new List<Ubicacion>();
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "SELECT id_ubicacion, estante, fila, columna FROM ubicacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Ubicacion
                        {
                            IdUbicacion = Convert.ToInt32(reader["id_ubicacion"]),
                            Estante = reader["estante"].ToString(),
                            Fila = reader["fila"].ToString(),
                            Columna = Convert.ToInt32(reader["columna"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Ubicacion u)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO ubicacion (estante, fila, columna) VALUES (@estante, @fila, @columna)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estante", u.Estante);
                cmd.Parameters.AddWithValue("@fila", u.Fila);
                cmd.Parameters.AddWithValue("@columna", u.Columna);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}