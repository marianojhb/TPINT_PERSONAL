using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoPaciente
    {
        AccesoDatos ac = new AccesoDatos();
        
        public int AgregarPaciente(Paciente paciente)
        {
            SqlCommand comando = new SqlCommand();
            string consulta = "INSERT INTO USUARIOS (dni_U, nombre_U, apellido_U, tipo_U, sexo_U, nacionalidad_U, fechaNac_U, direccion_U, idLocalidad_U, idProvincia_U, email_U, telefono_U) VALUES (@dni, @nombre, @apellido, @tipo, @sexo, @nacionalidad, @fechaNac, @direccion, @idLocalidad, @idProvincia, @email, @telefono)";
            comando.CommandText  = consulta;
            comando.Connection = ac.obtenerConexion();
            comando.Parameters.AddWithValue("@dni", paciente.DNI);
            comando.Parameters.AddWithValue("@nombre", paciente.Nombre);
            comando.Parameters.AddWithValue("@apellido", paciente.Apellido);
            comando.Parameters.AddWithValue("@tipo", paciente.Tipo);
            comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
            comando.Parameters.AddWithValue("@nacionalidad", paciente.Nacionalidad);
            comando.Parameters.AddWithValue("@fechaNac", paciente.FechaNac);
            comando.Parameters.AddWithValue("@direccion", paciente.Direccion);
            comando.Parameters.AddWithValue("@idLocalidad", paciente.IdLocalidad);
            comando.Parameters.AddWithValue("@idProvincia", paciente.IdProvincia);
            comando.Parameters.AddWithValue("@email", paciente.Email);
            comando.Parameters.AddWithValue("@telefono", paciente.Telefono);
            return comando.ExecuteNonQuery();
        }
    }
}
