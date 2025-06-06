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

        private DataTable obtenerTabla ()
        {
            return null;
        }



        // el adaptador

        // la conexion y obtener conexion


        // crear una acceso a conexion a una bbdd
    }
}
