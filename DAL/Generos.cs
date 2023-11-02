﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Generos
    {
        //Primeary Key
        [Key]//Indicar que es una primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Para idicar que es incrementable
        public int id_genero { get; set; }

        public string? nombre_genero { get; set; }
        public string? descripcion_genero { get; set; }


    }
}
