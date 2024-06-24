using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_Data.Models.catalogs
{
    public class Clasificaciones
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClasificacion {  get; set; }
        [Required, MaxLength(100)] 
        public string name { get; set; }

    }
}
