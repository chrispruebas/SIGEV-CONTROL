using SIGEV.Datos;
using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEV.Controlador
{
    public class UsuarioController

    {
        private readonly UsuarioDAL usuarioDAL = new UsuarioDAL();

        public Usuario IniciarSesion(string idUsuario, string contrasena)
        {
            
            if (string.IsNullOrWhiteSpace(idUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return null;
            }

            UsuarioDAL dal = new UsuarioDAL();
            return dal.ValidarLogin(idUsuario, contrasena);
        }
    }
}
