using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPersona
    {
        public Persona GetPersona(Persona p)
        {
            DaoPersona daoPersona = new DaoPersona();

            return daoPersona.GetPersona(p);
        }
    }
}
