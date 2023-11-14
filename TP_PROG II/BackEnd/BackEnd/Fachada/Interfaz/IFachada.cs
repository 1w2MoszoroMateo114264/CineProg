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
        List<Funciones> ObtenerFunciones();
        List<Edades> ObtenerEdades();
        List<Forma_de_pagos> ObtenerFormasPago();
        List<Genero_Pelis> ObtenerGenero_Pelis();
        List<Peliculas> ObtenerPeliculas();
        List<Salas> ObtenerSalas();
        List<Sucursales> ObtenerSucursales();
        List<Tipo_Entrada> ObtenerTipoEntradas();
        List<Butacas> ObtenerButacas();
        bool SaveFactura(Factura oFactura);
    }
}
