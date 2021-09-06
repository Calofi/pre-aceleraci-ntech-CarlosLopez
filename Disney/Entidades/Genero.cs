﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disney.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string Imagen { get; set; }

        public ICollection<Pelicula_Serie> Pelicula_Series { get; set; }


    }
}
