using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4.Practicas
{
    public partial class Practica_2 : Form
    {
        public Practica_2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        
            
        {
            // Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Escribe un nombre");
                return;
            }

            // Validar que el precio sea número mayor a 0
            if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Escribe un precio mayor a 0");
                return;
            }

           
            Producto producto = new Producto();
            producto.Nombre = txtnombre.Text;
            producto.Precio = precio;

            
            MessageBox.Show(" Guardado:\n\n" + producto.MostrarInfo());

         
            txtnombre.Clear();
            txtprecio.Clear();
        }
    }
    }

