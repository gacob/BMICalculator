using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    class EspecialidadRepository
    {
        private readonly ConexionDB conexion;

        public EspecialidadRepository()
        {
            conexion = new ConexionDB();
        }

        // ///////////////////////////////////////////////////
        // Especialidad: Nueva Especialidad, Modificar Especialidad.
        // ///////////////////////////////////////////////////

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            // Conectarte
            using var conn = conexion.ObtenerConexion();
            conn.Open();

            // Consulta
            string sql = "INSERT INTO `cita` (`idEspecialidad`, `idPaciente`, `idMedico`, `Fecha`, `Hora`, `Anulada`) VALUES (@idEspecialidad, @idPaciente, @idMedico, @Fecha, @Hora)";
            MySqlCommand cmd = new(sql, conn);

            // Añadir parámetros a la consulta
            cmd.Parameters.AddWithValue("@idEspecialidad", cita.IdEspecialidad);
            cmd.Parameters.AddWithValue("@idPaciente", cita.IdPaciente);
            cmd.Parameters.AddWithValue("@idMedico", cita.IdMedico);
            cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
            cmd.Parameters.AddWithValue("@hora", cita.Hora);

            // Ejecutar
            cmd.ExecuteNonQuery();
        }

        public void ModificarEspecialidad(Especialidad especialidad)
        {
            // Conectarte
            using var conn = conexion.ObtenerConexion();
            conn.Open();

            // Consulta
            string sql = "UPDATE `cita` SET `idEspecialidad`=@idEspecialidad, `idPaciente`=@idPaciente, `idMedico`=@idMedico, `Fecha`=@Fecha, `Hora`=@Hora, `Anulada`=@Anulada WHERE `id`=@id;";
            MySqlCommand cmd = new(sql, conn);

            // Añadir parámetros a la consulta
            cmd.Parameters.AddWithValue("@idEspecialidad", cita.IdEspecialidad);
            cmd.Parameters.AddWithValue("@idPaciente", cita.IdPaciente);
            cmd.Parameters.AddWithValue("@idMedico", cita.IdMedico);
            cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
            cmd.Parameters.AddWithValue("@hora", cita.Hora);
            cmd.Parameters.AddWithValue("@anulada", cita.Anulada);
            cmd.Parameters.AddWithValue("@idCita", cita.Id);

            // Ejecutar
            cmd.ExecuteNonQuery();
        }

    }
}
