using SIGEV.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SIGEV.Vista
{
    public partial class FormMenu : Form
    {
        private readonly SIGEV.Modelos.Usuario usuarioSesion;
        public FormMenu(SIGEV.Modelos.Usuario usuario)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            lblUsuarioLogueado.Text = $"Usuario: {usuarioSesion.Nombre} ({usuarioSesion.Cargo})";
            Button[] tarjetasModulo = { btnProductos, btnKardex, btnUbicaciones, btnLotes };

            btnProductos.Text = "📦  PRODUCTOS";
            btnKardex.Text = "📊  KARDEX";
            btnUbicaciones.Text = "📍  UBICACIÓN";
            btnLotes.Text = "🏷️️  LOTES";

            foreach (Button btn in tarjetasModulo)
            {
               
                btn.Size = new System.Drawing.Size(260, 85);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Estilo de Colores Accesible (WCAG AA Contraste)
                btn.BackColor = System.Drawing.Color.FromArgb(11, 37, 69); // Azul Oscuro Corporativo
                btn.ForeColor = System.Drawing.Color.White;

                // Tipografía y Alineación
                btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(15, 0, 0, 0); // Margen interno izquierdo
                btn.Cursor = Cursors.Hand;
            }

            // Estilo especial para el Botón Cerrar Sesión
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FlatAppearance.BorderSize = 1;
            btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnCerrarSesion.BackColor = System.Drawing.Color.White;
            btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCerrarSesion.Text = "🚪 Cerrar Sesión";
            btnCerrarSesion.Cursor = Cursors.Hand;
        }

        private void btnUbicaciones_Click(object sender, EventArgs e) => new FormUbicacion().ShowDialog();

        private void btnProductos_Click(object sender, EventArgs e) => new FormProducto().ShowDialog();
     
        private void btnLotes_Click(object sender, EventArgs e) => new FormLote().ShowDialog();

        private void btnKardex_Click(object sender, EventArgs e) => new FormKardex(usuarioSesion.Id).ShowDialog();

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
