using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_programada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrardia_Click(object sender, EventArgs e)
        {
            
        {
            int dia;

            // ✅ Validar que sea un número
            if (!int.TryParse(txtmostrardia.Text, out dia))
            {
                MessageBox.Show("Error: Ingresa un número válido",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtmostrardia.Clear();
                txtmostrardia.Focus();
                return;
            }

            // ✅ Evaluar con switch
            switch (dia)
            {
                case 1:
                    MessageBox.Show("Lunes", "Día de la semana");
                    break;
                case 2:
                    MessageBox.Show("Martes", "Día de la semana");
                    break;
                case 3:
                    MessageBox.Show("Miércoles", "Día de la semana");
                    break;
                case 4:
                    MessageBox.Show("Jueves", "Día de la semana");
                    break;
                case 5:
                    MessageBox.Show("Viernes", "Día de la semana");
                    break;
                case 6:
                    MessageBox.Show("Sábado", "Día de la semana");
                    break;
                case 7:
                    MessageBox.Show("Domingo", "Día de la semana");
                    break;
                default:
                    MessageBox.Show("Error: Ingresa un número entre 1 y 7",
                                    "Rango inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtmostrardia.Clear();
                    txtmostrardia.Focus();
                    break;
            }
        }
    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Realmente deseas salir de la aplicación?",
                                        "Confirmar salida",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true; // ❌ Cancela el cierre, se queda abierto
            }
            // Si dice Sí, se cierra normalmente ✅
        }
    }
    }
}
