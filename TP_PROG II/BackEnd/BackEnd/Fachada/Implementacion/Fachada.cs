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
        public List<Butacas> ObtenerButacas()
        {
            return fDao.GetButacas();
        }

        public List<Edades> ObtenerEdades()
        {
            return pDao.GetEdades();
        }

        public List<Forma_de_pagos> ObtenerFormasPago()
        {
            return fDao.GetFormasPago();
        }

        public List<Funciones> ObtenerFunciones()
        {
            return fDao.GetFunciones();
        }

        public List<Genero_Pelis> ObtenerGenero_Pelis()
        {
            return pDao.GetGenero_Pelis();
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            return fDao.GetPeliculas();
        }

        public List<Salas> ObtenerSalas()
        {
            return fDao.GetSalas();
        }

        public List<Sucursales> ObtenerSucursales()
        {
            return fDao.GetSucursales();
        }

        public List<Tipo_Entrada> ObtenerTipoEntradas()
        {
            return fDao.GetTipoEntradas();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return fDao.crearFactura(oFactura);
        }
    }
}
