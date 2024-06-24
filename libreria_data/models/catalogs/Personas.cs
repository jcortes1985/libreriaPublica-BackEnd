using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_DataLayer.Models.catalogs
{
    public class Personas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersona { get; set; }
        [Required, MaxLength(50)]
        public string APaterno { get; set; }
        [Required, MaxLength(50)]
        public string AMaterno { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        [Required, MaxLength(100)]
        public string Direccion { get; set; }
        [Required, MaxLength(100)]
        public string Telefono { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        public int activo { get; set; }


    }
}
