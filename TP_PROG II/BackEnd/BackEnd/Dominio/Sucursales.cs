using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Sucursales
    {
        public int IdSucursal { get; set; }
        public string Barrio { get; set; }
        public string Nombre { get; set; }
        public List<Salas> lstSalas { get; set; }
        public Sucursales()
        {
            lstSalas = new List<Salas>();
        }

        public Sucursales(int idSucursal, string barrio, string nombre)
        {
            IdSucursal = idSucursal;
            Barrio = barrio;
            Nombre = nombre;
        }
    }
}
