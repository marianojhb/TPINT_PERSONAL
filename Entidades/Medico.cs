using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        private string _usuario;
        private string _password;
        private string _legajo;
        private int _codEspecialidad;
        private string _horario;
        private bool _estado;
        public Medico() { }
        public string getUsuario() { return _usuario; }
        public void setUsuario(string usuario) { _usuario = usuario; }
        public string getPassword() { return _password; }
        public void setPassword(string password) { _password = password; }
        public string getLegajo() { return _legajo; }
        public void setLegajo(string legajo) { _legajo = legajo; }
        public int getCodEspecialidad() { return _codEspecialidad; }
        public void setCodEspecialidad(int codEspecialidad) { _codEspecialidad = codEspecialidad; }
        public string getHorario(int horario) { return _horario; }
        public void setHorario (string horario) { _horario = horario; }
        public bool getEstado() { return _estado; }
        public void setEstado(bool estado) {  _estado = estado; }
    }
}
