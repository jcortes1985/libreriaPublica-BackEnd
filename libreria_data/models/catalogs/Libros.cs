using libreria_publica_Data.Models.catalogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.library
{
    public class Libros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ICollection<Generos> Genero { get; set; }
        public ICollection<Clasificaciones> clasificacion { get; set; }
        [Required, MaxLength(100)]
        public string titulo { get; set; }
        [Required, MaxLength(250)]
        public string trama { get; set; }
        public int hojas { get; set; }
        public int numLibros { get; set; }
        public int soloUsers { get; set; }

    }
}
