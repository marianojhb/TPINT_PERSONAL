using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoAdministrador
    {
        AccesoDatos ac = new AccesoDatos();
        
        public DaoAdministrador() { }

        public bool existeUsuarioAdministrador(Administrador administrador)
        {
            string consulta = "SELECT 1 FROM USUARIOS WHERE usuario_U = '" + administrador.Username + "' AND password_U = '" + administrador.Password + "'";
            bool accesoAprobado = (ac.Existe(consulta));
            return accesoAprobado;
        }
    }
}
