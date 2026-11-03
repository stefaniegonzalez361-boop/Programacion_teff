using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_6.Unidad_6
{
    internal class Producto
    {
    }
}

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

}

public class ProductoLogica
{
    public List<Producto> ObtenerProductos()
    {
        return new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 450000m },
            new Producto { Nombre = "Mouse",  Precio = 8500m },
            new Producto { Nombre = "Teclado", Precio = 15000m }
        };
    }
}