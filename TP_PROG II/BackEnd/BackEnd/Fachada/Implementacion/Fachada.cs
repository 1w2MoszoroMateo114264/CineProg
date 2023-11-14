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
        private IFacturaDao dao;
        public Fachada()
        {
            dao = new FacturaDao();
        }
        public List<Butacas> ObtenerButacas()
        {
            return dao.GetButacas();
        }

        public List<Edades> ObtenerEdades()
        {
            return dao.GetEdades();
        }

        public List<Forma_de_pagos> ObtenerFormasPago()
        {
            return dao.GetFormasPago();
        }

        public List<Funciones> ObtenerFunciones()
        {
            return dao.GetFunciones();
        }

        public List<Genero_Pelis> ObtenerGenero_Pelis()
        {
            return dao.GetGenero_Pelis();
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            return dao.GetPeliculas();
        }

        public List<Salas> ObtenerSalas()
        {
            return dao.GetSalas();
        }

        public List<Sucursales> ObtenerSucursales()
        {
            return dao.GetSucursales();
        }

        public List<Tipo_Entrada> ObtenerTipoEntradas()
        {
            return dao.GetTipoEntradas();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return dao.crearFactura(oFactura);
        }
    }
}
