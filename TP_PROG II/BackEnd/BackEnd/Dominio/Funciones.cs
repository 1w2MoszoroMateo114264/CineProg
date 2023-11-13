using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Funciones
    {
		private int nroFuncion;

		public int NroFuncion
		{
			get { return nroFuncion; }
			set { nroFuncion = value; }
		}
		private DateTime dia;

		public DateTime Dia
		{
			get { return dia; }
			set { dia = value; }
		}
		private string hora;

		public string Hora
		{
			get { return hora; }
			set { hora = value; }
		}
		private Peliculas pelicula;

		public Peliculas Pelicula
		{
			get { return pelicula; }
			set { pelicula = value; }
		}

		private Salas sala;

		public Salas Sala
		{
			get { return sala; }
			set { sala = value; }
		}
        public Funciones(int nroFuncion, DateTime dia, string hora, Peliculas pelicula, Salas sala)
        {
			this.nroFuncion = nroFuncion;
			this.dia = dia;
			this.hora = hora;
			this.pelicula = pelicula;
			this.sala = sala;
        }
        public Funciones()
        {
				
        }


    }
}
