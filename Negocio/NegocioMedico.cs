using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMedico
    {
        DaoMedico daoMedico = new DaoMedico();
        public int AgregarMedico(Medico m)
        {
            return daoMedico.AgregarMedico(m);
        }
    }
}
