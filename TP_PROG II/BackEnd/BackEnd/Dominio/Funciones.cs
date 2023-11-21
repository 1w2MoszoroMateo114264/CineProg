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
		private int idPelicula;

		public int IdPelicula
		{
			get { return idPelicula; }
			set { idPelicula = value; }
		}

		private int nroSala;

		public int NroSala
		{
			get { return nroSala; }
			set { nroSala = value; }
		}
        public Funciones(int nroFuncion, DateTime dia, string hora, int pelicula, int sala)
        {
			this.nroFuncion = nroFuncion;
			this.dia = dia;
			this.hora = hora;
			this.idPelicula = pelicula;
			this.nroSala = sala;
        }
        public Funciones()
        {
				
        }

        public override string ToString()
        {
			return Dia.ToString("dd/MM/yyyy") + " " + Hora;
        }

    }
}
