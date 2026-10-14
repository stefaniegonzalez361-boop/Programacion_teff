using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_4.Practicas
{
    public class Producto
    {
        // Campos privados
        private string nombre;
        private decimal precio;

        // Propiedad Nombre con validación
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else
                    nombre = "Sin nombre";
            }
        }

        // Propiedad Precio con validación
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    precio = 0;
            }
        }

        // Método para mostrar información
        public string MostrarInfo()
        {
            return $"Producto: {Nombre}\nPrecio: ₡{Precio:F2}";
        }
    }
}
