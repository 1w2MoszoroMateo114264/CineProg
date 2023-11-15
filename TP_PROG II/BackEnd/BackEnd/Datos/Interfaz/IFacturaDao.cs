﻿using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Datos.Interfaz
{
    public interface IFacturaDao
    {
        List<Funciones> GetFunciones();
        List<Forma_de_pagos> GetFormasPago();
        List<Peliculas> GetPeliculas();
        List<Salas> GetSalas();
        List<Sucursales> GetSucursales();
        List<Tipo_Entrada> GetTipoEntradas();
        List<Butacas> GetButacas();
        //-----------------PELICULAS----------------------//
        bool crearFactura(Factura oFactura);
        bool actualizarFactura(Factura oFactura);
        List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, int dni);
        
    }
}
