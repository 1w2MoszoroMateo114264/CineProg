using BackEnd.Datos;
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
        List<Funciones> ObtenerFuncionesFiltradas(List<Parametro> lstFiltros);
        List<Forma_de_pagos> ObtenerFormasPago();
        List<Peliculas> ObtenerPeliculasDisponibles();
        List<Salas> ObtenerSalas();
        List<Tipo_Entrada> ObtenerTipoEntradas();
        List<ButacasXFunciones> ObtenerButacas(List<Parametro> lstParametros);
        bool ModEstadoButaca(List<ButacasXFunciones> listaButacas);
        bool SaveFactura(Factura oFactura);
        //-----------------PELICULAS----------------------//
        bool CrearPelicula(Peliculas oPelicula);
        bool ModPelicula(Peliculas oPelicula);
        bool DarAltaOBajaPelicula(int idPelicula);
        List<Peliculas> ObtenerPeliculasFiltradas(List<Parametro> lstFiltros);
        List<Genero_Pelis> ObtenerGenero_Pelis();
        List<Edades> ObtenerEdades();
        List<Peliculas> ObtenerPeliculas();
        //-----------------LOGIN----------------------//
        bool LoginCheck(string user, string pass);
    }
}
