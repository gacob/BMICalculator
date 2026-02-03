using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    internal class Compañia
    {
        private int Id {  get; set; }
        private String? Nombre {  get; set; }
        private String? Descripcion { get; set; }
        private int? Baja { get; set; }
    }
}
