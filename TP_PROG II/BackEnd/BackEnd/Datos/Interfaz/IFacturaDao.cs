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
        List<Peliculas> GetPeliculasDisponibles();
        List<Salas> GetSalas();
        List<Tipo_Entrada> GetTipoEntradas();
        List<ButacasXFunciones> GetButacas(List<Parametro> lstParametros);
        bool ModEstadoButaca(List<ButacasXFunciones> listaButacas);
        bool crearFactura(Factura oFactura);
        bool actualizarFactura(Factura oFactura);
        List<Factura> ObtenerFacturaPorFiltros(List<Parametro> lstParametros);
        
    }
}
