using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_6
{
    internal class Estudiante
    {
    }
}


namespace EjerciciosPracticos
{
    public class Estudiante : Persona
    {
        public int EdadCalculada
        {
            get { return DateTime.Now.Year - AnioNacimiento; }
        }
    }
}