using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Disney.Contexto;
using Disney.Entidades;

namespace Disney.Controllers
{
    public class ControladorGenero
    { [ApiController]
      [Route(template: "api/[Controller] ")]


        public class Generocontrolador : ControllerBase
            {
            private readonly DisneyContexto _disneyContexto;
            public Generocontrolador(DisneyContexto contexto) 
            {
                _disneyContexto = contexto;
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_disneyContexto.Generos.ToList());
            }

            [HttpPost]
            public IActionResult Post(Genero genero)
            {
                _disneyContexto.Generos.Add(genero);
                _disneyContexto.SaveChanges();
                return Ok(_disneyContexto.Generos.ToList());
            }

            [HttpPut]
            public IActionResult Put(Genero genero)
            {
                if (_disneyContexto.Generos.FirstOrDefault( x:genero => x.Id == Genero.Id) == null) return BadRequest(error: "EL genero no existe");

                var internalGenero = _disneyContexto.Generos.Find(genero.Id);


                internalGenero.Imagen = genero.Imagen;
                internalGenero.Nombre = genero.Nombre;


                _disneyContexto.SaveChanges();
                return Ok( _disneyContexto.Generos.ToList());
            }

            [HttpDelete]
            [Route(template:"{Id}")]

            public IActionResult Delete (int Id)
            {
               
                if (_disneyContexto.Generos.FirstOrDefault(x:Genero=> x.Id == Genero.Id) == null) return BadRequest(error: "EL genero no existe");
                var internalGenero = _disneyContexto.Generos.Find(Id);
                _disneyContexto.Generos.Remove(internalGenero);

                _disneyContexto.SaveChanges();
                return Ok(_disneyContexto.Generos.ToList());
            }

        }





    }




}
