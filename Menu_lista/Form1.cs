using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarServicios();
            cmbServios.ContextMenuStrip = contextMenuStrip1;
            btnCalcular.Click += btnCalcular_Click;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbServios.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbServios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un servicio.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string servicio = cmbServios.SelectedItem.ToString();
            double precio;

            switch (servicio)
            {
                case "Instalación de software":
                    precio = 15000;
                    break;
                case "Mantenimiento":
                    precio = 20000;
                    break;
                case "Soporte técnico":
                    precio = 10000;
                    break;
                default:
                    MessageBox.Show("El servicio seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            MessageBox.Show(
                "Servicio: " + servicio + Environment.NewLine +
                "Precio: ₡" + precio.ToString("N0", CultureInfo.GetCultureInfo("es-CR")),
                "Servicio seleccionado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarServicios()
        {
            string[] servicios =
            {
                "Instalación de software",
                "Mantenimiento",
                "Soporte técnico"
            };

            foreach (string servicio in servicios)
            {
                if (!cmbServios.Items.Contains(servicio))
                {
                    cmbServios.Items.Add(servicio);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
