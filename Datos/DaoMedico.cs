using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoMedico
    {
        AccesoDatos ac = new AccesoDatos();

        public int AgregarMedico(Medico m)
        {
            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@DNI", m.DNI);
            comando.Parameters.AddWithValue("@NOMBRE", m.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO", m.Apellido);
            comando.Parameters.AddWithValue("@TIPO", m.Tipo);
            comando.Parameters.AddWithValue("@SEXO", m.Sexo);
            comando.Parameters.AddWithValue("@NACIONALIDAD", m.Nacionalidad);
            comando.Parameters.AddWithValue("@FECHANAC", m.FechaNac);
            comando.Parameters.AddWithValue("@DIRECCION", m.Direccion);
            comando.Parameters.AddWithValue("@IDPROVINCIA", m.IdProvincia);
            comando.Parameters.AddWithValue("@IDLOCALIDAD", m.IdLocalidad);
            comando.Parameters.AddWithValue("@EMAIL", m.Email);
            comando.Parameters.AddWithValue("@TELEFONO", m.Telefono);
            comando.Parameters.AddWithValue("@CODESPECIALIDAD", m.CodEspecialidad);
            comando.Parameters.AddWithValue("@HORARIO", m.Horario);
            comando.Parameters.AddWithValue("@USUARIO", m.Username);
            comando.Parameters.AddWithValue("@PASSWORD", m.Password);

            string nombreSP = "SP_AGREGARMEDICO";
             
            return ac.ejecutarProcedimientosAlmacenados(comando, nombreSP);
        }
    }
}
