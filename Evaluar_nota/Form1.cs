using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluar_nota
{
    public partial class Form1 : Form
    {
        private readonly Color colorOriginalResultado;

        public Form1()
        {
            InitializeComponent();
            colorOriginalResultado = lblresultado.BackColor;
            AsegurarCategorias();
            btnevaluar.Click += btnevaluar_Click;
            btnlimpiar.Click += btnlimpiar_Click;
        }

        private string ClasificarNota(double nota)
        {
            if (nota >= 90)
            {
                return "Excelente";
            }
            else if (nota >= 80)
            {
                return "Muy bueno";
            }
            else if (nota >= 70)
            {
                return "Bueno";
            }
            else if (nota >= 60)
            {
                return "Regular";
            }

            return "Deficiente";
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            double nota;

            if (!double.TryParse(txtnota.Text, out nota) || nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota numérica entre 0 y 100.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoria = ClasificarNota(nota);
            lblresultado.Text = categoria;
            int indiceCategoria = lstcategoria.FindStringExact(categoria);
            lstcategoria.SelectedIndex = indiceCategoria;

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
                lblresultado.BackColor = colorOriginalResultado;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnota.Clear();
            lblresultado.Text = "Resultado";
            lblresultado.BackColor = colorOriginalResultado;
            lstcategoria.SelectedIndex = -1;
            txtnota.Focus();
        }

        private void AsegurarCategorias()
        {
            string[] categorias = { "Excelente", "Muy bueno", "Bueno", "Regular", "Deficiente" };

            foreach (string categoria in categorias)
            {
                if (lstcategoria.FindStringExact(categoria) == -1)
                {
                    lstcategoria.Items.Add(categoria);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
