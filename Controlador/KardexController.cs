using SIGEV.Datos;
using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Controlador
{
    public class KardexController
    {
        private readonly KardexDAL kardexDAL = new KardexDAL();
        private readonly LoteDAL loteDAL = new LoteDAL();

        public string RegistrarMovimiento(string tipo, int cantidad, string idLote, string usuario)
        {
            if (cantidad <= 0)
                return "La cantidad debe ser mayor a cero.";
            Lote lote = loteDAL.ObtenerPorId(idLote);
            if (lote == null)
                return "El lote especificado no existe.";

            int cambioCantidad = 0;

            if (tipo.ToUpper() == "SALIDA")
            {
                if (lote.FechaVencimiento < DateTime.Now)
                    return "No se puede dar salida a un lote vencido.";

                if (lote.Cantidad < cantidad)
                    return $"Stock insuficiente en el lote. Disponibles: {lote.Cantidad}";

                cambioCantidad = -cantidad;
            }
            else if (tipo.ToUpper() == "ENTRADA")
            {
                cambioCantidad = cantidad;
            }
            else
            {
                return "Tipo de movimiento no válido.";
            }

            Kardex k = new Kardex
            {
                IdMovimiento = Guid.NewGuid().ToString().Substring(0, 8),
                FechaMovimiento = DateTime.Now,
                TipoMovimiento = tipo,
                Cantidad = cantidad,
                IdLote = idLote,
                UsuarioResponsable = usuario
            };

            return kardexDAL.RegistrarMovimientoConTransaccion(k, cambioCantidad) ? "OK" : "Error en el movimiento.";
        }
    }
}