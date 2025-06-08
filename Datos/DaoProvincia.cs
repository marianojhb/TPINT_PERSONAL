using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoProvincia
    {
        AccesoDatos ac = new AccesoDatos();

        public List<Provincia> GetProvincias()
        {
            List<Provincia> lista = new List<Provincia>();
            string consulta = "SELECT idProvincia_P, nombre_P FROM Provincias";

            SqlCommand cmd = new SqlCommand(consulta, ac.obtenerConexion());
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Provincia p = new Provincia();
                p.IdProvincia = Convert.ToInt32(data["idProvincia_P"] );
                p.Nombre = data["nombre_P"].ToString();
                lista.Add(p);
            }

            data.Close();
            ac.cerrarConexion();
            return lista;
        }

    }
}
