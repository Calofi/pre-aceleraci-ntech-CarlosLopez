using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Disney.Entidades;



namespace Disney.Contexto
{
    public class DisneyContexto : DbContext
        {

        private const string Schema = "icons";
        public DisneyContexto(DbContextOptions options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema(Schema);
            builder.Entity<Genero>().HasData(new Genero
            {
                Id = 1,
                Nombre = " PEPE",
                Imagen = "el sapo",

            });

            


        }
       


        public DbSet<Genero> Generos { get; set; } = null;
        public DbSet<Pelicula_Serie> Pelicula_Series { get; set; } = null;
        public DbSet<Personaje> Personajes { get; set; } = null;










    }
}
