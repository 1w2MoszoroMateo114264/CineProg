using BackEnd.Datos.Interfaz;
using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "sp_InsertarMaestro";
                comando.Parameters.AddWithValue("@fecha", oFactura.Fecha);
                comando.Parameters.AddWithValue("@id_forma_de_pago", oFactura.FormaPago.IdPago);
                comando.Parameters.AddWithValue("@dni_cliente", oFactura.DniCliente);

                SqlParameter parametro = new SqlParameter();
                parametro.Direction = ParameterDirection.Output;
                parametro.ParameterName = "@nro_Factura";
                parametro.SqlDbType = SqlDbType.Int;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int FacturaNro = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (Detalle_factura df in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("sp_detallefactura",conexion,t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_detalleFactura", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@nro_funcion", df.Funciones.NroFuncion);
                    cmdDetalle.Parameters.AddWithValue("@nroFactura", FacturaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_entrada", df.TipoEntrada.IdEntrada);
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", df.Butaca.IdButaca);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null) 
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public List<Butacas> GetButacas()
        {
            List<Butacas> lButacas = new List<Butacas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_funciones");
            foreach (DataRow fila in tabla.Rows)
            {
                Butacas oButacas = new Butacas();
                int IdButaca = int.Parse(fila["id_butaca"].ToString());
                int NroButaca = int.Parse(fila["nro_butaca"].ToString());
                int NroSala = int.Parse(fila["nro_sala"].ToString());
                oButacas.IdButaca = IdButaca;
                oButacas.NroButaca = NroButaca;
                oButacas.NroSala = NroSala;
                lButacas.Add(oButacas);
            }
            return lButacas;
        }

        public List<Edades> GetEdades()
        {
            List<Edades> lEdades = new List<Edades>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_funciones");
            foreach (DataRow fila in tabla.Rows)
            {
                Edades oEdades = new Edades();
                int id = int.Parse(fila["id_edad"].ToString());
                string clasificacion = fila["clasificacion"].ToString();
                oEdades.ID = id;
                oEdades.Clasificacion = clasificacion;
                lEdades.Add(oEdades);
            }
            return lEdades;
        }

        public List<Forma_de_pagos> GetFormasPago()
        {
            List<Forma_de_pagos> lFormasPago = new List<Forma_de_pagos>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_funciones");
            foreach (DataRow fila in tabla.Rows)
            {
                Forma_de_pagos oFormaPago = new Forma_de_pagos();
                int IdPago = int.Parse(fila["IdPago"].ToString());
                string FormaPago = fila["descripcion"].ToString();
                oFormaPago.IdPago = IdPago;
                oFormaPago.FormaPago = FormaPago;
                lFormasPago.Add(oFormaPago);
            }
            return lFormasPago;
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

        public List<Genero_Pelis> GetGenero_Pelis()
        {
            throw new NotImplementedException();
        }

        public List<Peliculas> GetPeliculas()
        {
            throw new NotImplementedException();
        }

        public List<Salas> GetSalas()
        {
            throw new NotImplementedException();
        }

        public List<Sucursales> GetSucursales()
        {
            throw new NotImplementedException();
        }

        public List<Tipo_Entrada> GetTipoEntradas()
        {
            throw new NotImplementedException();
        }

        public List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, int dni)
        {
            List<Factura> lstFactura = new List<Factura>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultarFactura_ConFiltros", lFiltros);
            //mapear un registro de la tabla a un objeto del modelo de dominio
            foreach (DataRow fila in tabla.Rows)
            {
                Presupuesto p = new Presupuesto();
                p.PresupuestoNro = int.Parse(fila["presupuesto_nro"].ToString());
                p.Fecha = DateTime.Parse(fila["fecha"].ToString());
                p.Cliente = fila["cliente"].ToString();
                p.Descuento = double.Parse(fila["descuento"].ToString());
                lPresupuestos.Add(p);
            }
            return lPresupuestos;
        }
    }
}
