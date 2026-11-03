using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Desea guardar los cambios?",
       "Confirmar",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Cambios guardados.");
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            ProductoLogica logica = new ProductoLogica();
            string texto = "";

            foreach (Producto p in logica.ObtenerProductos())
            {
                texto += p.Nombre + " - ₡" + p.Precio + "\n";
            }

            MessageBox.Show(texto, "Lista de productos");
        }
    }
}
