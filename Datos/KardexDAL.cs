using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Datos
{
    public class KardexDAL
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public bool RegistrarMovimientoConTransaccion(Kardex k, int cambioCantidad)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                try
                {
                    // 1. Actualiza el stock en la tabla Lote
                    string queryLote = "UPDATE lote SET cantidad = cantidad + @cambio WHERE id_lote = @idLote";
                    SqlCommand cmdLote = new SqlCommand(queryLote, conn, tx);
                    cmdLote.Parameters.AddWithValue("@cambio", cambioCantidad);
                    cmdLote.Parameters.AddWithValue("@idLote", k.IdLote);
                    cmdLote.ExecuteNonQuery();

                    // 2. Registra el movimiento en el Kardex
                    string queryKardex = "INSERT INTO kardex (id_movimiento, fecha_movimiento, tipo_movimiento, cantidad, id_lote, usuario_responsable) " +
                                         "VALUES (@id, @fecha, @tipo, @cant, @idLote, @usuario)";
                    SqlCommand cmdKardex = new SqlCommand(queryKardex, conn, tx);
                    cmdKardex.Parameters.AddWithValue("@id", k.IdMovimiento);
                    cmdKardex.Parameters.AddWithValue("@fecha", k.FechaMovimiento);
                    cmdKardex.Parameters.AddWithValue("@tipo", k.TipoMovimiento);
                    cmdKardex.Parameters.AddWithValue("@cant", k.Cantidad);
                    cmdKardex.Parameters.AddWithValue("@idLote", k.IdLote);
                    cmdKardex.Parameters.AddWithValue("@usuario", k.UsuarioResponsable);
                    cmdKardex.ExecuteNonQuery();

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
