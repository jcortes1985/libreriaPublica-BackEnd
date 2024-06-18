using libreria_publica_Data.Models.library;
using libreria_publica_Data.Models.security;
using libreria_publica_DataLayer.Models.catalogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_DataLayer.Models.operations
{
    public class TransaccionesLibro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {  get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<Personas> Persona { get; set; }
        public ICollection<Libros> Libro { get; set; }
        public DateTime FechaTransaccion {  get; set; }
        public DateTime FechaRegreso { get; set; }

    }
}
