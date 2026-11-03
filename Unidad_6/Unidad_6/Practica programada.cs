using PracticaProgramada5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Unidad_6
{
   
    public partial class Practica_programada : Form
    {
        private List<Empleado> lista_Empleados = new List<Empleado>();
        public Practica_programada()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int anio;
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Ingresá un año de nacimiento válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal sueldo;
            if (!decimal.TryParse(txtSueldo.Text, out sueldo) || sueldo <= 0)
            {
                MessageBox.Show("El sueldo debe ser mayor a 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp = new Empleado
            {
                Nombre = txtNombre.Text.Trim(),
                AnioNacimiento = anio,
                Sueldo = sueldo
            };
            lista_Empleados.Add(emp);

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista_Empleados;

            txtNombre.Clear();
            txtAnio.Clear();
            txtSueldo.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
    "¿Desea guardar los cambios?",
    "Confirmar",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Cambios guardados.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }
    }
}
