using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void btnevaluar_Click(object sender, EventArgs e) { }
        


private string ClasificarNota(double nota)
        {
            if (nota >= 90)
                return "Excelente";
            else if (nota >= 80)
                return "Muy bueno";
            else if (nota >= 70)
                return "Bueno";
            else if (nota >= 60)
                return "Regular";
            else
                return "Deficiente";
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double nota;

            if (!double.TryParse(txtnota.Text, out nota))
            {
                MessageBox.Show("Ingrese una nota válida.");
                txtnota.Focus();
                return;
            }

            if (nota < 0 || nota > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100.");
                txtnota.Focus();
                return;
            }

            string categoria = ClasificarNota(nota);

            lblresultado.Text = "Resultado: " + categoria;

            lstcategorias.SelectedIndex = -1;

            for (int i = 0; i < lstcategorias.Items.Count; i++)
            {
                if (lstcategorias.Items[i].ToString() == categoria)
                {
                    lstcategorias.SelectedIndex = i;
                    break;
                }
            }

            if (nota >= 90)
            {
                lblresultado.BackColor = Color.LightGreen;
            }
            else if (nota < 60)
            {
                lblresultado.BackColor = Color.LightCoral;
            }
            else
            {
                lblresultado.BackColor = SystemColors.Control;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnota.Clear();
            lblresultado.Text = "Resultado";
            lblresultado.BackColor = SystemColors.Control;
            lstcategorias.SelectedIndex = -1;
            txtnota.Focus();
        }

    }
}

