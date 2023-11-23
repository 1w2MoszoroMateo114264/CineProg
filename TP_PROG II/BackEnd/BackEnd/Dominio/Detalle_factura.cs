using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Detalle_factura
    {
        private int funcion;

        public int Funcion
        {
            get { return funcion; }
            set { funcion = value; }
        }

        private int tipoEntrada;

        public int TipoEntrada
        {
            get { return tipoEntrada; }
            set { tipoEntrada = value; }
        }
        private int butaca;

        public int Butaca
        {
            get { return butaca; }
            set { butaca = value; }
        }

        public Detalle_factura(int funciones, int tipoEntrada, int butaca)
        {
            this.funcion = funciones;
            this.tipoEntrada = tipoEntrada;
            this.butaca = butaca;
        }

        public Detalle_factura()
        {
        }
    }
}
