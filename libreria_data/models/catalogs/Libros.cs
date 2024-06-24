using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libreria_publica_Data.Models.catalogs
{
    public class Libros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLibro { get; set; }
        [Required]
        public int idClasificacion { get; set; }
        [Required]
        public int idGenero { get; set; }
        [Required, MaxLength(100)]
        public string titulo { get; set; }
        [Required, MaxLength(250)]
        public string trama { get; set; }
        public int? hojas { get; set; }
        public int numLibros { get; set; }
        public int soloUsers { get; set; }
        public int librosDisponibles {  get; set; }

    }
}
