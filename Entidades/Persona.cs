﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public char Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNac { get; set; }
        public string Direccion { get; set; }
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Localidad { get; set; }   
        public string Provincia { get; set; }   
        public string Imagen {  get; set; }
    }
}