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
        public double Precio { get; set; }
        public Forma_de_pagos(int idPago, string formaPago, double precio)
        {
            IdPago = idPago;
            FormaPago = formaPago;
            Precio = precio;
        }

        public Forma_de_pagos()
        {
        }
    }
}
