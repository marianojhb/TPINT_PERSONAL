using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarMedico.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}