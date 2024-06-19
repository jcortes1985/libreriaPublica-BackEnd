﻿using libreria_publica_DataLayer.Models.operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_publica_Data.Models.catalogs
{
    public class Generos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idGenero { get; set; }
        [Required, MaxLength(100)]
        public string name { get; set; }


    }
}
