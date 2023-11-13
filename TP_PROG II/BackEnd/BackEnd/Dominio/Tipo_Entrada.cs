using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Tipo_Entrada
    {
		private int idEntrada;

		public int IdEntrada
		{
			get { return idEntrada; }
			set { idEntrada = value; }
		}

		private string tipoEntrada;

		public string TipoEntrada
		{
			get { return tipoEntrada; }
			set { tipoEntrada = value; }
		}

		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

    }
}
