using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;
        private HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametro p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }

        public bool LoginCheck(string sP, string user, string pass)
        {
            SqlConnection cnn = new SqlConnection(Properties.Resources.CadenaConexion);
            bool flag = true;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sP, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    flag = false;
                }



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
            return flag;
        }
    }
}
