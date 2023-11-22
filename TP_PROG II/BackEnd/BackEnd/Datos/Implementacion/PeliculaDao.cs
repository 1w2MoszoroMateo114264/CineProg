using BackEnd.Datos.Interfaz;
using BackEnd.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Datos.Implementacion
{
    public class PeliculaDao : IPeliculaDao
    {
        public bool CrearPelicula(Peliculas oPelicula)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("sp_InsPelicula", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@titulo", oPelicula.Titulo);
                comando.Parameters.AddWithValue("@id_genero", oPelicula.IdGenero);
                comando.Parameters.AddWithValue("@id_edad", oPelicula.IdEdad);
                comando.Parameters.AddWithValue("@duracion", oPelicula.Duracion);
                comando.Parameters.AddWithValue("@descripcion", oPelicula.Descripcion);
                comando.Parameters.AddWithValue("@estado_pelicula", oPelicula.EstadoPelicula);

                comando.ExecuteNonQuery();

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

        public bool DarAltaOBajaPelicula(int idPelicula)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("sp_ModEstado_Pelicula", conexion,t);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPelicula", idPelicula);
                comando.ExecuteNonQuery();
                t.Commit() ;
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

        public List<Edades> GetEdades()
        {
            List<Edades> lEdades = new List<Edades>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_edades");
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

        public List<Genero_Pelis> GetGenero_Pelis()
        {
            List<Genero_Pelis> lGernero_Pelis = new List<Genero_Pelis>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_Genero_Pelis");
            foreach (DataRow fila in tabla.Rows)
            {
                Genero_Pelis oGenero_Pelis = new Genero_Pelis();
                int id = int.Parse(fila["id_genero"].ToString());
                string genero = fila["descripcion"].ToString();
                oGenero_Pelis.Id = id;
                oGenero_Pelis.Genero = genero;
                lGernero_Pelis.Add(oGenero_Pelis);
            }
            return lGernero_Pelis;
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

        public List<Peliculas> GetPeliculasFiltradas(List<Parametro> lstFiltros)
        {
            List<Peliculas> lPeliculas = new List<Peliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_ConsultarPeliculas_Filtradas", lstFiltros);
            foreach ( DataRow fila in tabla.Rows)
            {
                Peliculas oPeli = new Peliculas();
                oPeli.IdPelicula = int.Parse(fila["id_pelicula"].ToString());
                oPeli.Titulo = fila["titulo"].ToString();
                oPeli.IdGenero = int.Parse(fila["id_genero"].ToString());
                oPeli.IdEdad  = int.Parse(fila["id_edad"].ToString());
                oPeli.Duracion = int.Parse(fila["duracion"].ToString());
                oPeli.Descripcion = fila["descripcion"].ToString();
                oPeli.EstadoPelicula = fila["estado_pelicula"].ToString();
                lPeliculas.Add(oPeli);
            }
            return lPeliculas;
        }

        public bool ModPelicula(Peliculas oPelicula)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("sp_ModPelicula", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPelicula", oPelicula.IdPelicula);
                comando.Parameters.AddWithValue("@titulo", oPelicula.Titulo);
                comando.Parameters.AddWithValue("@idGenero", oPelicula.IdGenero);
                comando.Parameters.AddWithValue("@idEdad", oPelicula.IdEdad);
                comando.Parameters.AddWithValue("@duracion", oPelicula.Duracion);
                comando.Parameters.AddWithValue("@desc", oPelicula.Descripcion);
                comando.Parameters.AddWithValue("@estado", oPelicula.EstadoPelicula);

                comando.ExecuteNonQuery();
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
    }
}
