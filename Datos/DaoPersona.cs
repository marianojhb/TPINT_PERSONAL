using Entidades;
using System;
using System.Collections.Generic;
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
            persona = ac.GetPersona(p.Username);
            return persona;
        }
        
    }
}
