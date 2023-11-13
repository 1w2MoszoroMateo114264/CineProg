using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Forma_de_pagos
    {
        public int IdPago { get; set; }
        public string FormaPago { get; set; }
        public Forma_de_pagos(int idPago, string formaPago)
        {
            IdPago = idPago;
            FormaPago = formaPago;
        }

        public Forma_de_pagos()
        {
        }
    }
}
