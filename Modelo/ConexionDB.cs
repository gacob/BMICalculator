using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    internal class ConexionDB
    {
        private readonly string _connectionString;
        public ConexionDB() {
            // Cambia valores para tu conexión
            _connectionString = "Server=localhost;Database=centromedico;User ID=root;Password=usuario;SslMode=none;";
        }

        // Obtener conexion
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(_connectionString);
        }
    }


}
