using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    internal class Cita
    {
        public int Id { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime Fecha { get; set; }
        public String? Hora { get; set; }
        public int? Anulada { get; set; }
    }
}
