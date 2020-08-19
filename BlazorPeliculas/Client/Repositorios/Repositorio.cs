using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPelicuales()
        {
            return new List<Pelicula>()
                {
                    new Pelicula(){Titulo="Spider-Man 20", Lanzamiento= new DateTime(2020,11,3)},
                    new Pelicula(){Titulo="Anne with an e", Lanzamiento= new DateTime(2021,08,15)},
                    new Pelicula(){Titulo="Lucifer, Evil´s Lord", Lanzamiento= new DateTime(2021,03,20)},
                    new Pelicula(){Titulo="Starship trooper 5", Lanzamiento= new DateTime(2022,07,11)}
                };
        }
    }
}
