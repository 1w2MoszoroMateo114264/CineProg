using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Datos.Interfaz
{
    public interface IPeliculaDao
    {
        bool CrearPelicula(Peliculas oPelicula);
        bool ModPelicula(Peliculas oPelicula);
        bool DarAltaOBajaPelicula(int idPelicula);
        List<Peliculas> GetPeliculasFiltradas(List<Parametro> lstFiltros);
        List<Edades> GetEdades();
        List<Genero_Pelis> GetGenero_Pelis();
        List<Peliculas> GetPeliculas();


    }
}
