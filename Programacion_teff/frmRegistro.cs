using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_teff
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
 
        {
            string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;

            txtResultado.Text = "¡Felicidades, " + nombreCompleto + "!\n" +
                                "Usted fue registrado con éxito \n\n" +
                                "Correo: " + txtCorreo.Text + "\n" +
                                "Edad: " + txtEdad.Text + " años";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtEdad.Clear();
            txtResultado.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    }

