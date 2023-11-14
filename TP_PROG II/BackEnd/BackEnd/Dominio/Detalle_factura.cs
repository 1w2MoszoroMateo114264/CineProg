using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Detalle_factura
    {
        private int funciones;

        public int Funciones
        {
            get { return funciones; }
            set { funciones = value; }
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
            this.funciones = funciones;
            this.tipoEntrada = tipoEntrada;
            this.butaca = butaca;
        }
    }
}
