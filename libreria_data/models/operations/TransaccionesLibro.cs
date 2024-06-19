using libreria_publica_Data.Models.catalogs;
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
        public int idTransaccion {  get; set; }
        public int idUser { get; set; }
        public int idPersona { get; set; }
        public int idLibro { get; set; }
        public DateTime FechaTransaccion {  get; set; }
        public DateTime FechaRegreso { get; set; }

    }
}
