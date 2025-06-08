using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoPersona
    {
        AccesoDatos ac = new AccesoDatos();
        
        public Persona GetPersona (Persona p)
        {
            Persona persona = new Persona();
            string consulta = "SELECT * FROM USUARIOS AS [U] INNER JOIN LOCALIDADES AS [L] ON U.idLocalidad_U = L.idLocalidad_L INNER JOIN PROVINCIAS AS [P] ON L.idProvincia_L = P.idProvincia_P WHERE U.usuario_U = @usuario ";

            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@usuario", p.Username);
            comando.CommandText = consulta;
            comando.Connection = ac.obtenerConexion();
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
            comando.Connection.Close();
            return persona;
        }
        
    }
}
