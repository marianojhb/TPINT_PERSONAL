using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class accesoDatos
    {
        private const string cadenaConexion = @"Data Source=MABELO360\SQLEXPRESS;Initial Catalog=BDClinica;Integrated Security=True;Trust Server Certificate=True";
        public accesoDatos() { } // constructor por defecto

        private SqlConnection obtenerConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        private SqlDataAdapter obtenerAdaptador(string consulta, SqlConnection conn)
        {
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(consulta, conn);
                return adapter;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        private DataTable obtenerTabla(string nombreTabla, string consultaSql)
        {
            DataSet ds = new DataSet();
            SqlConnection sqlConnection = obtenerConexion();
            SqlDataAdapter adapter = obtenerAdaptador(consultaSql, sqlConnection);
            adapter.Fill(ds);
            sqlConnection.Close();
            return ds.Tables[nombreTabla];
        }

        public int ejecutarProcedimientosAlmacenados(SqlCommand comando, string nombreSP)
        {
            int filasCambiadas = 0;
            SqlConnection sqlConnection = obtenerConexion();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand = comando;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = nombreSP;
            filasCambiadas = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return filasCambiadas;
        }
        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = obtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

    }
}
