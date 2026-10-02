using SIGEV.Datos;
using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Controlador
{
    public class UbicacionController
    {
        private readonly UbicacionDAL ubicacionDAL = new UbicacionDAL();

        public List<Ubicacion> ObtenerTodas() => ubicacionDAL.Listar();

        public string Registrar(string estante, string fila, int columna)
        {
            if (string.IsNullOrEmpty(estante) || string.IsNullOrEmpty(fila))
                return "El estante y la fila no pueden estar vacíos.";

            Ubicacion u = new Ubicacion { Estante = estante, Fila = fila, Columna = columna };
            return ubicacionDAL.Insertar(u) ? "OK" : "Error al guardar en BD.";


        }
    }
}
