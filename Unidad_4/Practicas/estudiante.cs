using System;
using System.Windows.Forms;

namespace Unidad_4.Practicas
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public void MostrarDatos()
        {
            string info = $"Nombre: {Nombre}\nEdad: {Edad} años\nCurso: {Curso}";
            MessageBox.Show(info, "Datos del Estudiante");
        }
    }
}