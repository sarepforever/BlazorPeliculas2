using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
