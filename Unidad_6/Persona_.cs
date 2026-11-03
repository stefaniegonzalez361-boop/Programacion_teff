using PracticaProgramada5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_6
{
    internal class Persona_
    {
    }
}
namespace PracticaProgramada5
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int AnioNacimiento { get; set; }
    }
}

namespace PracticaProgramada5
{
    public class Empleado : Persona
    {
        public decimal Sueldo { get; set; }

        // Propiedad calculada: solo tiene get, no se guarda
        public int Edad
        {
            get { return DateTime.Now.Year - AnioNacimiento; }
        }
    }
}
