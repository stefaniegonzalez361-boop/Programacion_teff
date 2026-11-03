
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<EjerciciosPracticos.Estudiante> lista = new List<EjerciciosPracticos.Estudiante>
    {
        new EjerciciosPracticos.Estudiante { Nombre = "Ana",  AnioNacimiento = 2002 },
        new EjerciciosPracticos.Estudiante { Nombre = "Luis", AnioNacimiento = 1999 }
    };

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = lista;



        }
    }
}
