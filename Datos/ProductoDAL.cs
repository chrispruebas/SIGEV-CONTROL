using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIGEV.Datos
{
    public class ProductoDAL
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "SELECT id_producto, nombre, stock, id_ubicacion FROM producto";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = reader["id_producto"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Stock = Convert.ToInt32(reader["stock"]),
                            IdUbicacion = Convert.ToInt32(reader["id_ubicacion"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Producto p)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO producto (id_producto, nombre, stock, id_ubicacion) VALUES (@id, @nombre, @stock, @idUbicacion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", p.IdProducto);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@idUbicacion", p.IdUbicacion);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(string idProducto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "DELETE FROM producto WHERE id_producto = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idProducto);

                con.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
    }
}
