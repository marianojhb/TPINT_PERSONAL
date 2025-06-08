using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class AccesoDatos
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TPINT_PERSONAL;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection obtenerConexion()
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

        public SqlDataAdapter obtenerAdaptador(string consulta, SqlConnection conn)
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
        public Boolean Existe(String consulta)
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

        public Persona GetPersona(Persona p)
        {
            Persona persona = new Persona();
            //string consulta = "SELECT * FROM USUARIOS WHERE usuario_U = @usuario ";
            string consulta = "SELECT * FROM USUARIOS AS [U] INNER JOIN LOCALIDADES AS [L] ON U.idLocalidad_U = L.idLocalidad_L INNER JOIN PROVINCIAS AS [P] ON L.idProvincia_L = P.idProvincia_P WHERE U.usuario_U = @usuario ";

            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@usuario", p.Username);
            comando.CommandText = consulta;
            comando.Connection = obtenerConexion();
            SqlDataReader data = comando.ExecuteReader();
            if (data.Read())
            {
                persona.Nombre = data["nombre_U"].ToString();
                persona.Apellido = data["apellido_U"].ToString();
                persona.DNI = data["dni_U"].ToString();
                persona.Tipo = data["tipo_U"].ToString();
                persona.Sexo = data["sexo_U"].ToString()[0];
                persona.Nacionalidad = data["nacionalidad_U"].ToString();
                persona.FechaNac = data["fechaNac_U"].ToString();
                persona.IdLocalidad = Convert.ToInt32(data["idLocalidad_U"]);
                persona.Localidad = data["nombre_L"].ToString();
                persona.IdProvincia = Convert.ToInt32(data["idProvincia_U"]);
                persona.Provincia = data["nombre_P"].ToString();
                persona.Email = data["email_U"].ToString();
                persona.Telefono = data["telefono_U"].ToString();
                persona.Username = data["usuario_U"].ToString();
                persona.Password = data["password_U"].ToString();


            }
            return persona;
        }

    }
}
