using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class NegocioAdministrador
    {
        DaoAdministrador daoAdministrador = new DaoAdministrador();

        public NegocioAdministrador() { }

        public bool existeUsuarioAdministrador(string usuario, string password)
        {
            Administrador administrador = new Administrador();
            administrador.Username = usuario;
            administrador.Password = password;
            return daoAdministrador.existeUsuarioAdministrador(administrador);
        }
    }
}
