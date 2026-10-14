using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_4.Practicas;

namespace Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();
            miProducto.Nombre = "Tennis";
            miProducto.Precio = 40000;
            MessageBox.Show(miProducto.MostrarInfo(), "Información del producto");
            
        }
    }
}
