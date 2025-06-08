using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string usuario = Session["Usuario"] as string;

                if (!string.IsNullOrEmpty(usuario))
                {
                    lblUsuario.Text = "Usuario: " + usuario;
                    lblFullName.Text = Session["FullName"] as string;
                    cerrarSesion.Visible = true;
                }
                else
                {
                    lblUsuario.Text = "Usuario: Invitado";
                    cerrarSesion.Visible = false;
                }

            }

        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = String.Empty;
            cerrarSesion.Visible = true;
            Response.Redirect("~/Inicio.aspx");
        }
    }
}