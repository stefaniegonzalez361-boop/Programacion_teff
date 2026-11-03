using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hayErrores = false;
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            double precio;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código del producto");
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del producto");
                hayErrores = true;
            }

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un precio válido mayor que cero");
                hayErrores = true;
            }

            if (hayErrores)
            {
                return;
            }

            Producto producto = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Precio = precio
            };

            double precioConIVA = producto.ObtenerPrecioConIVA();
            CultureInfo culturaCostaRica = CultureInfo.GetCultureInfo("es-CR");

            MessageBox.Show(
                "Código del producto: " + producto.Codigo + Environment.NewLine +
                "Nombre del producto: " + producto.Nombre + Environment.NewLine +
                "Precio original: ₡" + producto.Precio.ToString("N2", culturaCostaRica) + Environment.NewLine +
                "Precio con IVA del 13%: ₡" + precioConIVA.ToString("N2", culturaCostaRica),
                "Datos del producto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
