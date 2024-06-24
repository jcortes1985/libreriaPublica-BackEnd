using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_Data.Models.security
{
    public class Menu
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu { get; set; }
        [Required]
        public string name { get; set; }
       
    }
}
