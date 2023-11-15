﻿using BackEnd.Datos;
using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Fachada.Interfaz
{
    public interface IFachada
    {
        //-----------------FACTURAS----------------------//
        List<Funciones> ObtenerFunciones();
        List<Forma_de_pagos> ObtenerFormasPago();
        List<Peliculas> ObtenerPeliculas();
        List<Salas> ObtenerSalas();
        List<Sucursales> ObtenerSucursales();
        List<Tipo_Entrada> ObtenerTipoEntradas();
        List<Butacas> ObtenerButacas();
        bool SaveFactura(Factura oFactura);
        //-----------------PELICULAS----------------------//
        bool CrearPelicula(Peliculas oPelicula);
        bool ModPelicula(Peliculas oPelicula);
        bool DarAltaOBajaPelicula(int idPelicula);
        List<Peliculas> ObtenerPeliculasFiltradas(List<Parametro> lstFiltros);
        List<Genero_Pelis> ObtenerGenero_Pelis();
        List<Edades> ObtenerEdades();
    }
}
