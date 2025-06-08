using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPaciente
    {
        DaoPaciente daoPaciente = new DaoPaciente();

        public int AgregarPaciente (Paciente paciente)
        {
            return daoPaciente.AgregarPaciente(paciente);
        }
    }
}
