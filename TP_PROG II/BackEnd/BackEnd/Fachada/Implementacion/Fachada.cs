using BackEnd.Datos;
using BackEnd.Datos.Implementacion;
using BackEnd.Datos.Interfaz;
using BackEnd.Dominio;
using BackEnd.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Fachada.Implementacion
{
    public class Fachada : IFachada
    {
        private IFacturaDao fDao;
        private IPeliculaDao pDao;
        public Fachada()
        {
            fDao = new FacturaDao();
            pDao = new PeliculaDao();
        }
        //-----------------PELICULAS----------------------//
        public bool CrearPelicula(Peliculas oPelicula)
        {
            return pDao.CrearPelicula(oPelicula);
        }

        public bool DarAltaOBajaPelicula(int idPelicula)
        {
            return pDao.DarAltaOBajaPelicula(idPelicula);
        }

        public bool ModPelicula(Peliculas oPelicula)
        {
            return pDao.ModPelicula(oPelicula);
        }

        public List<Edades> ObtenerEdades()
        {
            return pDao.GetEdades();
        }

        public List<Genero_Pelis> ObtenerGenero_Pelis()
        {
            return pDao.GetGenero_Pelis();
        }
  
        public List<Peliculas> ObtenerPeliculas()
        {
            return pDao.GetPeliculas();
        }
        public List<Peliculas> ObtenerPeliculasFiltradas(List<Parametro> lstFiltros)
        {
            return pDao.GetPeliculasFiltradas(lstFiltros);
        }
        //-----------------FACTURAS----------------------//
        public List<ButacasXFunciones> ObtenerButacas(List<Parametro> lstParametros)
        {
            return fDao.GetButacas(lstParametros);
        }
        public bool ModEstadoButaca(List<ButacasXFunciones> listaButacas)
        {
            return fDao.ModEstadoButaca(listaButacas);
        }
        public List<Peliculas> ObtenerPeliculasDisponibles()
        {
            return fDao.GetPeliculasDisponibles();
        }
        public List<Forma_de_pagos> ObtenerFormasPago()
        {
            return fDao.GetFormasPago();
        }

        public List<Funciones> ObtenerFunciones()
        {
            return fDao.GetFunciones();
        }

        public List<Peliculas> sp_consultar_peliculas()
        {
            return fDao.GetPeliculasDisponibles();
        }

        public List<Salas> ObtenerSalas()
        {
            return fDao.GetSalas();
        }

        public List<Tipo_Entrada> ObtenerTipoEntradas()
        {
            return fDao.GetTipoEntradas();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return fDao.crearFactura(oFactura);
        }

        public List<Funciones> ObtenerFuncionesFiltradas(List<Parametro> lstFiltros)
        {
            return fDao.GetFuncionesFiltradas(lstFiltros);
        }

        //-----------Log In----------------//
        public bool LoginCheck(string user, string pass)
        {
            return HelperDao.ObtenerInstancia().LoginCheck("SP_LOGIN_CHECK", user, pass);
        }


    }
}
