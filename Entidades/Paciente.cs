using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private string _observacion; 
        public Paciente() { }
        public string getObservacion()
            { return _observacion; }
        public void setObservacion(string observacion)
        { _observacion = observacion; }
    }
}
