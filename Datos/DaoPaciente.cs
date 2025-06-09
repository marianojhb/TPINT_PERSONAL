using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public DataTable GetPacientes()
        {
            string consulta = "SELECT USUARIOS.imagen_U AS Imagen, USUARIOS.dni_U AS DNI, USUARIOS.nombre_U AS Nombre, USUARIOS.apellido_U AS Apellido, USUARIOS.sexo_U AS Sexo, USUARIOS.nacionalidad_U AS Nacionalidad, USUARIOS.fechaNac_U AS[Fecha de Nacimiento], USUARIOS.direccion_U AS Dirección, LOCALIDADES.nombre_L AS Localidad, PROVINCIAS.nombre_P AS Provincia, USUARIOS.email_U AS Email, USUARIOS.telefono_U AS Teléfono, USUARIOS.estado_U AS Estado FROM LOCALIDADES INNER JOIN PROVINCIAS ON LOCALIDADES.idProvincia_L = PROVINCIAS.idProvincia_P INNER JOIN USUARIOS ON LOCALIDADES.idLocalidad_L = USUARIOS.idLocalidad_U AND LOCALIDADES.idProvincia_L = USUARIOS.idProvincia_U WHERE(USUARIOS.tipo_U = '03') ORDER BY USUARIOS.apellido_U";

            return ac.ObtenerTabla(consulta);
        }
    }
}
