using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public double ObtenerPrecioConIVA()
        {
            return Precio * 1.13;
        }
    }
}
