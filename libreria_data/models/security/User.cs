using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_Data.Models.security
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }

        [Required, StringLength(100)]
        public string email {  get; set; }
        [Required, StringLength(50)]
        public string password { get; set; }
        [Required]
        public int IdRol { get; set; }

    }
}
