using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class InicioMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarPaciente.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}