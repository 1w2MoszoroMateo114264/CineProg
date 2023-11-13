﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Detalle_factura
    {
        private Funciones funciones;

        public Funciones Funciones
        {
            get { return funciones; }
            set { funciones = value; }
        }

        private Tipo_Entrada tipoEntrada;

        public Tipo_Entrada TipoEntrada
        {
            get { return tipoEntrada; }
            set { tipoEntrada = value; }
        }
        public Detalle_factura(Funciones funciones, Tipo_Entrada tipoEntrada)
        {
            this.funciones = funciones;
            this.tipoEntrada = tipoEntrada;
        }
    }
}
