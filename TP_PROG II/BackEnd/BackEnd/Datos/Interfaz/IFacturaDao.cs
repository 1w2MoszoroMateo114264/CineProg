using BackEnd.Dominio;
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
        List<Funciones> GetFuncionesFiltradas(List<Parametro> lstParametros);
        List<Forma_de_pagos> GetFormasPago();
        List<Peliculas> GetPeliculas();
        List<Salas> GetSalas();
        List<Tipo_Entrada> GetTipoEntradas();
        List<Butacas> GetButacas();
        bool crearFactura(Factura oFactura);
        bool actualizarFactura(Factura oFactura);
        List<Factura> ObtenerFacturaPorFiltros(List<Parametro> lstParametros);
        
    }
}
