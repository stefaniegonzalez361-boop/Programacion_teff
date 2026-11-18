using MySql.Data.MySqlClient;

namespace Unidad_7
{
    internal class Conexion
    {
        private readonly string cadena = "Server=127.0.0.1;Port=3306;Database=tienda;Uid=root;Pwd=*A123456789*;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
