using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.catalogs
{
    public class Clasificaciones
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {  get; set; }
        [Required, MaxLength(100)] 
        public string name { get; set; }
    }
}
