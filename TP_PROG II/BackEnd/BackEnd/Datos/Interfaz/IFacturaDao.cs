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
        bool crearFactura(Factura oFactura);
        bool actualizarFactura(Factura oFactura);
        List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, int dni);

    }
}
