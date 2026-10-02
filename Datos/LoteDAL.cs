using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Datos
{
    public class LoteDAL
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public Lote ObtenerPorId(string idLote)
        {
            Lote lote = null;
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "SELECT id_lote, id_producto, fecha_vencimiento, cantidad FROM lote WHERE id_lote = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idLote);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lote = new Lote
                        {
                            IdLote = reader["id_lote"].ToString(),
                            IdProducto = reader["id_producto"].ToString(),
                            FechaVencimiento = Convert.ToDateTime(reader["fecha_vencimiento"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"])
                        };
                    }
                }
            }
            return lote;
        }

        public bool Insertar(Lote l)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO lote (id_lote, id_producto, fecha_vencimiento, cantidad) VALUES (@id, @idProd, @fecha, @cant)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", l.IdLote);
                cmd.Parameters.AddWithValue("@idProd", l.IdProducto);
                cmd.Parameters.AddWithValue("@fecha", l.FechaVencimiento);
                cmd.Parameters.AddWithValue("@cant", l.Cantidad);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}