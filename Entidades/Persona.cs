using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
		protected string _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _tipo;
        protected char _sexo;
        protected string _nacionalidad;
        protected string _fechaNac;
        protected string _direccion;
        protected int _idLocalidad;
        protected int _idProvincia;
        protected string _email;
        protected string _telefono;


		public Persona() { }

		public string getDni()
		{ return _dni; }
		public void setDni(string dni)
		{ _dni = dni; }
		public string getNombre()
		{ return _nombre; }
		public void setNombre(string nombre)
		{ _nombre = nombre; }
		public string getApellido()
		{ return _apellido; }
		public void setApellido(string apellido)
		{ _apellido = apellido;}
		public string getTipo()
		{ return _tipo; }
		public void setTipo(string tipo)
		{ _tipo = tipo;}
		public char getSexo()
		{ return _sexo; }
		public void setSexo(char sexo)
		{ _sexo = sexo;}
		public string getNacionalidad()
		{  return _nacionalidad; }
		public void setNacionalidad(string nacionalidad)
		{ _nacionalidad = nacionalidad;}
		public string getFechaNac()
		{ return _fechaNac; }
		public void setFechaNac(string fechaNac)
		{ _fechaNac = fechaNac;}
		public string getDireccion()
			{ return _direccion; }
		public void setDireccion(string direccion)
		{  _direccion = direccion;}
		public int getIdLocalidad()
		{ return _idLocalidad; }
		public void setIdLocalidad(int localidad)
			{ _idLocalidad = localidad ;}
		public int getIdProvincia()
		{ return _idProvincia; }
		public void setIdProvincia(int idProvincia)
		{ _idProvincia = idProvincia ;}
		public string getEmail()
			{ return _email; }
		public void setEmail(string email)
		{  _email = email;}
		public string getTelefono()
			{ return _telefono; }
		public void setTelefono(string telefono)
		{ _telefono = telefono;}
    }
}
