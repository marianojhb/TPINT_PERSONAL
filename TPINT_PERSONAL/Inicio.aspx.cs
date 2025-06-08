using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class Inicio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            NegocioLogin login = new NegocioLogin();
            Usuario u = new Usuario(txtUsuario.Text, txtPassword.Text);
            NegocioPersona negPersona = new NegocioPersona();
            Persona persona = new Persona();
            


            bool accesoAprobado = login.LoginOK(u);

            if (accesoAprobado)
            {
                // Si hay una persona logueada, muestro cartel de Cerrar Sesión
                Master.FindControl("cerrarSesion").Visible = true;

                // Guardo el nombre de usuario logueado en una variable de sesión para usar en toda la app
                Session["Usuario"] = txtUsuario.Text;


                // Busco datos de la persona que se logueó:
                persona.Username = txtUsuario.Text;
                persona = negPersona.GetPersona(persona);
                Session["FullName"] = persona.Nombre;


                // Busco el rol de la persona logueada para ver a donde la redirijo
                Persona personaRole = new Persona();
                personaRole.Username = txtUsuario.Text;
                string tipo = login.GetRole(personaRole);

                if (tipo == "01")
                {
                Response.Redirect("~/Administrador.aspx", false);
                Context.ApplicationInstance.CompleteRequest();

                }
                else if (tipo == "02")
                {
                    Response.Redirect("~/Medico.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
    }
}