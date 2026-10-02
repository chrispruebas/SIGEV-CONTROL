using SIGEV.Datos;
using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Controlador
{
    public class LoteController
    {
        private readonly LoteDAL loteDAL = new LoteDAL();

        public string Registrar(string idLote, string idProducto, DateTime vencimiento, int cantidad)
        {
            if (string.IsNullOrEmpty(idLote) || string.IsNullOrEmpty(idProducto))
                return "ID Lote e ID Producto son obligatorios.";

            if (cantidad <= 0)
            {
                return "Debe ingresar una cantidad mayor a cero.";
            }

            if (vencimiento <= DateTime.Now)
                return "La fecha de vencimiento debe ser posterior a hoy.";

            Lote l = new Lote { IdLote = idLote, IdProducto = idProducto, FechaVencimiento = vencimiento, Cantidad = cantidad };
            return loteDAL.Insertar(l) ? "OK" : "Error al registrar el lote.";
        }
    }
}