using SIGEV.Controlador;
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
    public partial class FormUbicacion : Form
    {
        private readonly UbicacionController controller = new UbicacionController();
        public FormUbicacion()
        {
            InitializeComponent();
        }
        private void FormUbicacion_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvUbicaciones.DataSource = controller.ObtenerTodas();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string res = controller.Registrar(txtEstante.Text, txtFila.Text, Convert.ToInt32(txtColumna.Value));

            if (res == "OK")
            {
                MessageBox.Show("Ubicación registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla(); // Refresca el DataGridView automáticamente
                txtEstante.Clear();
                txtFila.Clear();
                txtColumna.Value = 0;
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
