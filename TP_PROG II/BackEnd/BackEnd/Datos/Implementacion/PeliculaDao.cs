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
            bool resultado = false;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            SqlCommand comando = new SqlCommand("sp_ModEstado_Pelicula", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idPelicula", idPelicula);

            if (comando.ExecuteNonQuery() == 1)
            {
                resultado = true;
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
                int id = int.Parse(fila["id"].ToString());
                string genero = fila["genero"].ToString();
                oGenero_Pelis.Id = id;
                oGenero_Pelis.Genero = genero;
                lGernero_Pelis.Add(oGenero_Pelis);
            }
            return lGernero_Pelis;
        }

        public List<Peliculas> GetPeliculasFiltradas(List<Parametro> lstFiltros)
        {
            List<Peliculas> lPeliculas = new List<Peliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_ConsultarPeliculas_Filtradas", lstFiltros);
            foreach ( DataRow fila in tabla.Rows)
            {
                Peliculas oPeli = new Peliculas();
                oPeli.IdPelicula = int.Parse(fila[0].ToString());
                oPeli.Titulo = fila[1].ToString();
                oPeli.IdGenero = int.Parse(fila[2].ToString());
                oPeli.IdEdad  = int.Parse(fila[3].ToString());
                oPeli.Duracion = int.Parse(fila[4].ToString());
                oPeli.Descripcion = fila[5].ToString();
                oPeli.EstadoPelicula = fila[6].ToString();
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

                comando.ExecuteNonQuery();
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
