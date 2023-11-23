using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public int IdFormaPago { get; set; }
        public DateTime Fecha { get; set; }
        public int DniCliente { get; set; }
        public double Total { get; set; }
        public List<Detalle_factura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<Detalle_factura>();
        }
        public void AgregarDetalle(Detalle_factura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
    }
}
