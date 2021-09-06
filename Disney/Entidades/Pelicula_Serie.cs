using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Disney.Entidades
{
    public class Pelicula_Serie
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }

        public DateTime Creacion { get; set; }

        [Range(1, 5)] public int Calificacion { get; set; }

        public Personaje Personaje { get; set; }

        public ICollection<Personaje> Personajes; 





    }
}
