using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class ButacasXFunciones
    {
		private int nroFunciones;

		public int NroFunciones
        {
			get { return nroFunciones; }
			set { nroFunciones = value; }
		}
		private int nroButaca;

		public int NroButaca
		{
			get { return nroButaca; }
			set { nroButaca = value; }
		}

		private string estado;

		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}
        public ButacasXFunciones()
        {
            
        }
        public ButacasXFunciones(int nroFuncion, int nroButaca, string estado)
        {
			this.nroButaca = nroButaca;
			this.nroFunciones= nroFuncion;
			this.estado = estado;
        }

    }
}
