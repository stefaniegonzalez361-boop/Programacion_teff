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
    public partial class Estudian_tes : Form
    {
        public Estudian_tes()
        {
            InitializeComponent();
        }

        private void lblguardar_Click(object sender, EventArgs e)
        {
           
        {
            
            errorProvider1.Clear();
            bool datosCorrectos = true;

            
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                errorProvider1.SetError(txtnombre, "El nombre no puede estar vacío");
                datosCorrectos = false;
            }

            if (!int.TryParse(txtedad.Text, out int edad) || edad <= 0)
            {
                errorProvider1.SetError(txtedad, "La edad debe ser un número mayor a 0");
                datosCorrectos = false;
            }

            
            if (string.IsNullOrWhiteSpace(txtcurso.Text))
            {
                errorProvider1.SetError(txtcurso, "El curso no puede estar vacío");
                datosCorrectos = false;
            }

           
            if (datosCorrectos)
            {
               
                Estudiante estudiante = new Estudiante();

                
                estudiante.Nombre = txtnombre.Text;
                estudiante.Edad = edad;
                estudiante.Curso = txtcurso.Text;

                
                estudiante.MostrarDatos();

                
                txtnombre.Clear();
                txtedad.Clear();
                txtcurso.Clear();
            }
        }
    }
    }
}
