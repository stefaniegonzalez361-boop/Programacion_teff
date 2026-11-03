using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
         
            {
                // Limpiar errores previos
                errorProvider1.Clear();
                bool datosValidos = true;

                // Validar Código
                if (string.IsNullOrWhiteSpace(txtcodigo.Text))
                {
                    errorProvider1.SetError(txtcodigo, "El código no puede estar vacío");
                    datosValidos = false;
                }

                // Validar Nombre
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    errorProvider1.SetError(txtnombre, "El nombre no puede estar vacío");
                    datosValidos = false;
                }

                // Validar Precio
                if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)
                {
                    errorProvider1.SetError(txtprecio, "El precio debe ser mayor a cero");
                    datosValidos = false;
                }

                // Si todo está correcto, crear objeto y mostrar
                if (datosValidos)
                {
                    Producto producto = new Producto
                    {
                        Codigo = txtcodigo.Text.Trim(),
                        Nombre = txtnombre.Text.Trim(),
                        Precio = precio
                    };

                    string mensaje =
                        $"Código: {producto.Codigo}\n" +
                        $"Nombre: {producto.Nombre}\n" +
                        $"Precio sin IVA: ¢{producto.Precio:F2}\n" +
                        $"Precio con IVA (13%): ¢{producto.ObtenerPrecioConIVA:F2}";

                    MessageBox.Show(mensaje, "Datos del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
    

