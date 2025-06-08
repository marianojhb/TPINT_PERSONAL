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
            persona.Username = txtUsuario.Text;


            bool accesoAprobado = login.LoginOK(u);

            if (accesoAprobado)
            {
                // consultar que tipo de usuario es y de paso traer el nombre

                Session["Usuario"] = txtUsuario.Text;

                Persona personaRole = new Persona();
                personaRole.Username = txtUsuario.Text;
                string tipo = login.GetRole(personaRole);
                persona = negPersona.GetPersona(persona);
                Session["Tipo"] = tipo;
                Session["FullName"] = persona.Nombre + " " + persona.Apellido;

                Master.FindControl("cerrarSesion").Visible = true;
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