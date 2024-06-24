using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_DataLayer.Models.operations
{
    public class TransaccionesLibro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTransaccion {  get; set; }
        [Required]
        public int idPersona { get; set; }
        [Required]
        public int idLibro { get; set; }
        public DateTime? FechaTransaccion {  get; set; }
        public DateTime? FechaRegreso { get; set; }

    }
}
