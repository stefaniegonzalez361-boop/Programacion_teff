using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            int opcion;
            if (int.TryParse(txtopcion.Text, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MessageBox.Show("Opción 1 seleccionada");
                        break;
                    case 2:
                        MessageBox.Show("Opción 2 seleccionada");
                        break;
                    case 3:
                        MessageBox.Show("Opción 3 seleccionada");
                        break;
                    default:
                        MessageBox.Show("Opción no válida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
