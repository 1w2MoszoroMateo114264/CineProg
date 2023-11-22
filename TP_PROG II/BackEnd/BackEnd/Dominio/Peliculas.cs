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
        public int IdGenero { get; set; }
        public int IdEdad { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string EstadoPelicula { get; set; }
        public Peliculas()
        {

        }
        public Peliculas(int idPeli, string titulo, int idGenero, int idEdad, int duracion, string descripcion, string estadoPelicula)
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
            return Titulo + " | " + Duracion + " min | " + Descripcion + " | " ;
        }
    }
}
