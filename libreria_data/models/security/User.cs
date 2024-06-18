using libreria_publica_DataLayer.Models.catalogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.security
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string email {  get; set; }
        [Required, StringLength(50)]
        public string password { get; set; }
        public ICollection<Rol> rol { get; set; }
        public ICollection<Personas> personas { get; set; }
        
    }
}
