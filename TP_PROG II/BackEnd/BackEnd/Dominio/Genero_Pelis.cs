using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Genero_Pelis
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string genero;

		public string Genero
		{
			get { return genero; }
			set { genero = value; }
		}

        public Genero_Pelis(int id, string genero)
        {
            this.id = id;
			this.Genero = genero;
        }

        public Genero_Pelis()
        {
        }
    }
}
