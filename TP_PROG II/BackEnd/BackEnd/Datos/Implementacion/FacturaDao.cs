using BackEnd.Datos.Interfaz;
using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Datos.Implementacion
{
    public class FacturaDao : IFacturaDao
    {
        public bool actualizarFactura(Factura oFactura)
        {
            throw new NotImplementedException();
        }

        public bool crearFactura(Factura oFactura)
        {
            throw new NotImplementedException();
        }

        public List<Funciones> GetFunciones()
        {
            List<Funciones > lFunciones = new List<Funciones>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_funciones");
            //mapeo de objetos Funciones
            foreach(DataRow fila in tabla.Rows)
            {
                Funciones oFunciones = new Funciones();
                int nroFuncion = int.Parse(fila["nro_funcion"].ToString());
                DateTime dia = DateTime.Parse(fila["dia"].ToString());
                string hora = fila["hora"].ToString();
                string titulo = fila["titulo"].ToString();
                int nroSala = int.Parse(fila["nro_sala"].ToString());
                oFunciones.NroFuncion = nroFuncion;
                oFunciones.Dia = dia;
                oFunciones.Hora = hora;
                oFunciones.Pelicula.Titulo = titulo;
                oFunciones.Sala.NroSala = nroSala;
                lFunciones.Add(oFunciones);
            }
            return lFunciones;
        }

        public List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, int dni)
        {
            throw new NotImplementedException();
        }
    }
}
