using SIGEV.Datos;
using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Controlador
{
    public class ProductoController
    {

        private readonly ProductoDAL productoDAL = new ProductoDAL();

        public List<Producto> ObtenerTodos() => productoDAL.Listar();

        public string Registrar(string id, string nombre, int stock, int idUbicacion)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre))
                return "Código y nombre son obligatorios.";

            if (stock < 0)
                return "El stock no puede ser negativo.";

            Producto p = new Producto { IdProducto = id, Nombre = nombre, Stock = stock, IdUbicacion = idUbicacion };
            return productoDAL.Insertar(p) ? "OK" : "Error al insertar el producto.";
        }
        public string Eliminar(string idProducto, string cargoUsuario)
        {
            // CA-07.2: Restricción por rol
            if (cargoUsuario != "Administrador")
            {
                return "Solo el Administrador tiene permisos para eliminar productos.";
            }

            ProductoDAL dal = new ProductoDAL();
            bool exito = dal.Eliminar(idProducto); // <--- Guarda el booleano

            return exito ? "OK" : "No se pudo eliminar el producto de la base de datos.";
        }

    }
}