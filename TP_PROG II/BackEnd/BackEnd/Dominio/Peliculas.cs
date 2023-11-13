using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public Genero_Pelis IdGenero { get; set; }
        public Edades IdEdad { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string EstadoPelicula { get; set; }
        public Peliculas()
        {

        }
        public Peliculas(int idPeli, string titulo, Genero_Pelis idGenero, Edades idEdad, int duracion, string descripcion, string estadoPelicula)
        {
            IdPelicula = idPeli;
            Titulo = titulo;
            IdGenero = idGenero;
            Descripcion = descripcion;
            IdEdad = idEdad;
            Duracion = duracion;
            EstadoPelicula = estadoPelicula;
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
