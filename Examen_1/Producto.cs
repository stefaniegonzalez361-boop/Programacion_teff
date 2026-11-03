using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Producto
    {
    
    }
    namespace Examen_1
    {
        public class Producto
        {
            // Propiedades con get y set
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

            // Método para calcular precio con IVA 13%
            public decimal ObtenerPrecioConIVA()
            {
                const decimal IVA = 0.13m;
                return Precio * (1 + IVA);
            }
        }
    }
}

