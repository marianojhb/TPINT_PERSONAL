using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
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
            bool accesoAprobado = login.LoginOK(u);

            if (accesoAprobado)
            {
                // consultar que tipo de usuario es y de paso traer el nombre

                Session["Usuario"] = txtUsuario.Text;
                Master.FindControl("cerrarSesion").Visible = true;

                Persona persona = new Persona();
                persona.Username = txtUsuario.Text;
                string tipo = login.GetRole(persona);
                Session["Tipo"] = tipo;
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