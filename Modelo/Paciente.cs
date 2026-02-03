using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.Modelo
{
    /*
     * CREATE TABLE `paciente` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`Nombre` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Apellidos` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Direccion` VARCHAR(150) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`dni` VARCHAR(9) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Telefono` VARCHAR(9) NOT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`idCompañia` INT NULL DEFAULT '0',
	`email` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8mb4_0900_ai_ci',
	PRIMARY KEY (`id`) USING BTREE,
	INDEX `FK_paciente_compañia` (`idCompañia`) USING BTREE,
	CONSTRAINT `FK_paciente_compañia` FOREIGN KEY (`idCompañia`) REFERENCES `compañia` (`id`) ON UPDATE SET NULL ON DELETE SET NULL
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=InnoDB
AUTO_INCREMENT=4
;

     */
    internal class Paciente
    {
		public int Id {  get; set; }
        public String Nombre { get; set; } = String.Empty;
        public String Apellidos { get; set; } = String.Empty;
        public String Direccion { get; set; } = String.Empty;
        public String Dni { get; set; } = String.Empty;
        public String Telefono { get; set; } = String.Empty;
        public int? IdCompañia { get; set; }
        public String? Email { get; set; }
    }
}
