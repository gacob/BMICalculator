using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    internal class Medico
    {
		private int Id {  get; set; }
		private int? IdEspecialidad { get; set; }
		private String? Nombre { get; set; }
		private String? Apellidos { get; set; }
		private String? NumColegiado { get; set; }
		private String? Telefono { get; set; }
		private String? Dni {  get; set; }
		private String? Baja { get; set; }
		private String? Email { get; set; }
    }
}
