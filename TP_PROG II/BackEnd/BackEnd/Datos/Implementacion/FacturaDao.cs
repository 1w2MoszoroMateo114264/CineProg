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
                comando.Parameters.AddWithValue("@id_forma_de_pago", oFactura.IdFormaPago);
                comando.Parameters.AddWithValue("@dni_cliente", oFactura.DniCliente);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nro_Factura";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int FacturaNro = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (Detalle_factura df in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("sp_Insertardetalle", conexion,t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_detalleFactura", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@nro_funcion", df.Funciones);
                    cmdDetalle.Parameters.AddWithValue("@nro_Factura", FacturaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_entrada", df.TipoEntrada);
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", df.Butaca);
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
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_butacas");
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

        public List<Forma_de_pagos> GetFormasPago()
        {
            List<Forma_de_pagos> lFormasPago = new List<Forma_de_pagos>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_formasPago");
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
                oFunciones.Pelicula = new Peliculas();
                oFunciones.Pelicula.Titulo = titulo;
                oFunciones.Sala = new Salas();
                oFunciones.Sala.NroSala = nroSala;
                lFunciones.Add(oFunciones);
            }
            return lFunciones;
        }

        public List<Peliculas> GetPeliculas()
        {
            List<Peliculas> lPeliculas = new List<Peliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_peliculas");
            foreach (DataRow fila in tabla.Rows)
            {
                Peliculas oPeliculas = new Peliculas();
                int idPelicula = int.Parse(fila["id_pelicula"].ToString());
                string titulo = fila["titulo"].ToString();
                int genero = int.Parse(fila["id_genero"].ToString());
                int clasificacion = int.Parse(fila["id_edad"].ToString());
                int duracion = int.Parse(fila["duracion"].ToString());
                string descripcion = fila["descripcion"].ToString();
                string estadoPelicula = fila["estado_pelicula"].ToString();
                oPeliculas.IdPelicula = idPelicula;
                oPeliculas.Titulo = titulo;
                oPeliculas.IdGenero = genero;
                oPeliculas.IdEdad = clasificacion;
                oPeliculas.Duracion = duracion;
                oPeliculas.Descripcion = descripcion;
                oPeliculas.EstadoPelicula = estadoPelicula;
                lPeliculas.Add(oPeliculas);
            }
            return lPeliculas;
        }

        public List<Salas> GetSalas()
        {
            List<Salas> lSalas = new List<Salas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_salas");
            foreach (DataRow fila in tabla.Rows)
            {
                Salas oSalas = new Salas();
                int NroSala = int.Parse(fila["nro_sala"].ToString());
                int Capacidad = int.Parse(fila["capacidad"].ToString());
                int IdSucursal = int.Parse(fila["id_sucursal"].ToString());
                oSalas.NroSala = NroSala;
                oSalas.Capacidad = Capacidad;
                oSalas.IdSucursal = IdSucursal;
                lSalas.Add(oSalas);
            }
            return lSalas;
        }

        public List<Sucursales> GetSucursales()
        {
            List<Sucursales> lSucursales = new List<Sucursales>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_sucursales");
            foreach (DataRow fila in tabla.Rows)
            {
                Sucursales oSucursales = new Sucursales();
                int idSucursal = int.Parse(fila["id"].ToString());
                string barrio = fila["barrio"].ToString();
                string nombre = fila["nombre"].ToString();


                oSucursales.IdSucursal = idSucursal;
                oSucursales.Barrio = barrio;
                oSucursales.Nombre = nombre;
                lSucursales.Add(oSucursales);

            }
            return lSucursales;
        }

        public List<Tipo_Entrada> GetTipoEntradas()
        {
            List<Tipo_Entrada> lTipoEntrada = new List<Tipo_Entrada>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_tipo_entradas");
            foreach (DataRow fila in tabla.Rows)
            {
                Tipo_Entrada oTipoEntrada = new Tipo_Entrada();
                int id = int.Parse(fila["id"].ToString());
                string tipoEntrada = fila["tipoEntrada"].ToString();
                double precio = double.Parse(fila["precio"].ToString());

                oTipoEntrada.IdEntrada = id;
                oTipoEntrada.TipoEntrada = tipoEntrada;
                oTipoEntrada.Precio = precio;
                lTipoEntrada.Add(oTipoEntrada);
            }
            return lTipoEntrada;
        }

        public List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, int dni)
        {
            throw new NotImplementedException();
        }
    }
}
