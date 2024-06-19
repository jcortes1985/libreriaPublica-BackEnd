using libreria_publica_Data.Models.catalogs;
using libreria_publica_DataLayer.Models.operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.catalogs
{
    public class Libros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLibro { get; set; }
        public int idGenero { get; set; }
        public int idClasificacion { get; set; }
        [Required, MaxLength(100)]
        public string titulo { get; set; }
        [Required, MaxLength(250)]
        public string trama { get; set; }
        public int hojas { get; set; }
        public int numLibros { get; set; }
        public int soloUsers { get; set; }

    }
}
