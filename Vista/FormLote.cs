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
    public partial class FormLote : Form
    {
        public FormLote()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SIGEV.Controlador.LoteController controller = new SIGEV.Controlador.LoteController();
            string res = controller.Registrar(
                txtIdLote.Text,
                txtIdProducto.Text,
                dtpVencimiento.Value,
                Convert.ToInt32(txtCantidad.Value)
            );

            if (res == "OK")
            {
                MessageBox.Show("Lote registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdLote.Clear();
                txtIdProducto.Clear();
                txtCantidad.Value = 0;
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
