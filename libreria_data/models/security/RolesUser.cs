using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.security
{
    public class RolesUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRolUser { get; set; }
        public int IdUser { get; set; }
        public int IdRol { get; set; }

       
    }
}
