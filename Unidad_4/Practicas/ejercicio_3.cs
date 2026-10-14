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
    public partial class ejercicio_3 : Form
    {
        public ejercicio_3()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
          
        {
            errorProvider1.Clear(); 
            bool todoBien = true;

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                errorProvider1.SetError(txtnombre, "El nombre es obligatorio ");
                todoBien = false;
            }

            // Validar Precio
            if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)
            {
                errorProvider1.SetError(txtprecio, "Debe ser mayor a 0 ");
                todoBien = false;
            }

           
            if (todoBien)
            {
                Producto p = new Producto();
                p.Nombre = txtnombre.Text;
                p.Precio = precio;

                MessageBox.Show("¡Registrado!\n\n" + p.MostrarInfo(), "Éxito");

                txtnombre.Clear();
                txtprecio.Clear();
                errorProvider1.Clear();
            }
        }
    }
    }
}
