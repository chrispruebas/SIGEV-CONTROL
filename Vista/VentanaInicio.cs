using SIGEV.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SIGEV.Controlador.UsuarioController controller = new SIGEV.Controlador.UsuarioController();
            SIGEV.Modelos.Usuario user = controller.IniciarSesion(txtUsuario.Text, txtContrasena.Text);

            if (user != null)
            {
                MessageBox.Show($"Bienvenido {user.Nombre}", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenu menu = new FormMenu(user);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
    }

