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

namespace Calculo_salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            double horas;
            double pagoHora;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del trabajador.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!double.TryParse(txtHoras.Text, out horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de horas válida mayor que cero.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoras.Focus();
                return;
            }

            if (!double.TryParse(txtPagoHora.Text, out pagoHora) || pagoHora <= 0)
            {
                MessageBox.Show("Ingrese un pago por hora válido mayor que cero.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagoHora.Focus();
                return;
            }

            double salarioTotal;

            if (horas <= 40)
            {
                salarioTotal = horas * pagoHora;
            }
            else
            {
                double salarioNormal = 40 * pagoHora;
                double horasExtra = horas - 40;
                double pagoHorasExtra = horasExtra * pagoHora * 1.5;
                salarioTotal = salarioNormal + pagoHorasExtra;
            }

            CultureInfo culturaCostaRica = CultureInfo.GetCultureInfo("es-CR");
            MessageBox.Show(
                "Trabajador: " + nombre + Environment.NewLine +
                "Salario total: ₡" + salarioTotal.ToString("N2", culturaCostaRica),
                "Cálculo de salario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPagoHora.Clear();
            txtNombre.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
