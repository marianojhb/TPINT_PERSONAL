using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {
        private string _usuario;
        private string _password;
        public Administrador() { }
        public string getUsuario() { return _usuario; }
        public void setUsuario(string usuario) { _usuario = usuario; }
        public string getPassword() { return _password; }
        public void setPassword(string password) { _password = password; }
    }
}
