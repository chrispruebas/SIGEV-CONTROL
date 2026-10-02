using SIGEV.Controlador;
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
    public partial class FormProducto : Form
    {
        private readonly ProductoController controller = new ProductoController();
       
  

    
        public FormProducto()
        {
            InitializeComponent();
           

        }
        
        
        private void CargarTabla()
        {
            dgvProductos.DataSource = controller.ObtenerTodos();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string res = controller.Registrar(
                txtIdProducto.Text,
                txtNombre.Text,
                Convert.ToInt32(txtStock.Value),
                Convert.ToInt32(txtUbicacion.Text)
            );

            if (res == "OK")
            {
                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla(); // Refresca el DataGridView automáticamente
                txtIdProducto.Clear();
                txtNombre.Clear();
                txtStock.Value = 0;
                txtUbicacion.Clear();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar si hay una fila seleccionada en el DataGridView
                if (dgvProductos.CurrentRow == null || dgvProductos.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Por favor, selecciona un producto de la tabla antes de intentar eliminar.",
                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Obtener el código o ID de la celda seleccionada (evitando valores nulos)
                object valorCelda = dgvProductos.CurrentRow.Cells[0].Value;

                if (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                {
                    MessageBox.Show("No se pudo obtener el ID del producto seleccionado.",
                                    "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idProducto = valorCelda.ToString();

                // 3. Confirmación previa de seguridad
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar el producto con código {idProducto}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    
                    ProductoController controller = new ProductoController();

                    // . Llama al método pasando el ID y el Cargo del usuario logueado
                    string resultado = controller.Eliminar(idProducto, "Administrador");

                    // 3. Evalúa si la respuesta fue "OK"
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Producto eliminado exitosamente.", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarTabla(); // Descomenta esta línea si tienes un método para refrescar la tabla
                    }
                    else
                    {
                        // Si no fue "OK", muestra el mensaje retornado (por ejemplo, falta de permisos o error)
                        MessageBox.Show(resultado, "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // ex.StackTrace te dirá exactamente en qué archivo y número de línea ocurrió el Null
                MessageBox.Show("Detalle del error:\n" + ex.ToString(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        
    }
}
