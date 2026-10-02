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
    public partial class FormKardex : Form
    {
        private readonly KardexController controller = new KardexController();
       
        private readonly string usuarioActual;

        public FormKardex(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de movimiento (ENTRADA / SALIDA).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string res = controller.RegistrarMovimiento(
                cmbTipo.SelectedItem.ToString(),
                Convert.ToInt32(txtCantidad.Value),
                txtIdLote.Text,
                usuarioActual
            );

            if (res == "OK")
            {
                MessageBox.Show("Movimiento registrado correctamente en el Kardex.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdLote.Clear();
                txtCantidad.Value = 0;
            }
            else
            {
                MessageBox.Show(res, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
