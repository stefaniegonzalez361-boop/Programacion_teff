using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
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
            int numero;

            // Validar que sea un número
            if (!int.TryParse(txtnumero.Text, out numero))
            {
                MessageBox.Show("Error: El número ingresado es incorrecto. Por favor, ingrese un número válido.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtnumero.Clear();
                txtnumero.Focus();
                return;
            }

            // ✅ El switch va AQUÍ, después de la validación
            switch (numero)
            {
                case 1:
                    MessageBox.Show("El número ingresado es 1.", "Resultado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("El número ingresado es 2.", "Resultado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("El número ingresado es 3.", "Resultado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("El número ingresado es 4.", "Resultado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("El número debe estar en el rango de 1 a 4.", "Rango inválido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
    }
}
