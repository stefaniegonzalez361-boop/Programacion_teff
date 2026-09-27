using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculadora.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtsuma1.Text);
            double num2 = Convert.ToDouble(txtsuma2.Text);
            double resultado = num1 + num2;
            txtresultadosuma.Text = resultado.ToString();  
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtmult1.Text);
            double num2 = Convert.ToDouble(txtmult2.Text);
            double resultado = num1 * num2;
            txtresultadomult.Text = resultado.ToString();
        }
    }
}
