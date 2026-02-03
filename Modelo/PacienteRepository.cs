using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    class PacienteRepository
    {

        private readonly ConexionDB conexion;

        public PacienteRepository()
        {
            conexion = new();
        }

        // ///////////////////////////////////////////////////
        // Paciente: Nuevo Paciente, Modificar Paciente
        // ///////////////////////////////////////////////////

        public void AgregarPaciente(Paciente paciente)
        {
            // Conectarte
            using var conn = conexion.ObtenerConexion();
            conn.Open();

            // Consulta
            string sql = "INSERT INTO `paciente` (`Nombre`, `Apellidos`, `Direccion`, `dni`, `Telefono`, `idCompañia`, `email`) VALUES (@Nombre, @Apellidos, @Direccion, @dni, @Telefono, @idCompañia, @email);";
            MySqlCommand cmd = new(sql, conn);

            // Añadir parámetros a la consulta
            cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
            cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
            cmd.Parameters.AddWithValue("@dni", paciente.Dni);
            cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@idCompañia", paciente.IdCompañia);
            cmd.Parameters.AddWithValue("@email", paciente.Email);

            // Ejecutar
            cmd.ExecuteNonQuery();
        }

        public void ModificarPaciente(Paciente paciente)
        {
            // Conectarte 
            using var conn = conexion.ObtenerConexion();
            conn.Open();

            // Consulta
            string sql = "UPDATE `paciente` SET `Nombre`=@Nombre, `Apellidos`=@Apellidos, `Direccion`=@Direccion, `dni`=@dni, `Telefono`=@Telefono, `idCompañia`=@idCompañia, `email`=@email WHERE `id`=@id;";

            MySqlCommand cmd = new(sql, conn);

            // Añadir parámetros a la consulta
            cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
            cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
            cmd.Parameters.AddWithValue("@dni", paciente.Dni);
            cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@idCompañia", paciente.IdCompañia);
            cmd.Parameters.AddWithValue("@email", paciente.Email);
            cmd.Parameters.AddWithValue("@id", paciente.Id);

            // Ejecutar
            cmd.ExecuteNonQuery();
        }



    }
}
