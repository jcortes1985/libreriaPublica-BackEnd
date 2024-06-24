using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace libreria_data.models.security
{
    public class RolMenu
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRolMenu { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required]
        public int IdMenu { get; set; }
    }
}
