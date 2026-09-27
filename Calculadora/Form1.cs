using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            // Si no se necesita manejar el clic del label, dejar vacío o eliminar el evento.
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Leemos y convertimos los números
            double n1 = Convert.ToDouble(txtSuma1.Text);
            double n2 = Convert.ToDouble(txtSuma2.Text);

            // Sumamos
            double total = n1 + n2;

            // Mostramos resultado
            txtResultado.Text = "El resultado de la suma es: " + total;
        }
    }
}