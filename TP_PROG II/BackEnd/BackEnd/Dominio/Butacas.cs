using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Butacas
    {
        public int IdButaca { get; set; }
        public int NroButaca { get; set; }
        public int NroSala { get; set; }

        public Butacas()
        {
            IdButaca = 0;
            NroButaca = 0;
            NroSala = 0;
        }
        public Butacas(int idButaca, int nroButaca, int nroSala)
        {
            IdButaca = idButaca;
            NroButaca = nroButaca;
            NroSala = nroSala;
        }
    }
}
