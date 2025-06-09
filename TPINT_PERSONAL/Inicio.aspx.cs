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
            if (Session["Usuario"] == null || string.IsNullOrEmpty(Session["Usuario"].ToString()))
            {
                Response.Redirect("~/Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }

            else if (Session["Tipo"].ToString() == "01")
            {
                Response.Redirect("~/InicioAdministrador.aspx", false);
                Context.ApplicationInstance.CompleteRequest();

            }
            else if (Session["Tipo"].ToString() == "02")
            {
                Response.Redirect("~/InicioMedico.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}