using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Edades
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string clasificacion;

		public string Clasificacion
		{
			get { return clasificacion; }
			set { clasificacion = value; }
		}

        public Edades(int id, string clasificacion)
        {
			this.id = id;
			this.clasificacion = clasificacion;
        }
        public Edades()
        {
            
        }

    }
}
