using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TPINT_PERSONAL
{
    public partial class ListadoPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                if (Session["Tipo"] == null || (Session["Tipo"].ToString() != "01" && Session["Tipo"].ToString() != "02"))
                {
                    Response.Redirect("~/Login.aspx");
                    
                }
                
            }
            // CARGAR SIEMPRE:
            CargarPacientes();
        }
        protected void CargarPacientes()
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            DataTable dt = negocioPaciente.GetPacientes();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvPacientes.DataSource = dt;
                gvPacientes.DataBind();
            }
            else
            {
                // Mensaje de prueba en consola o log
                Response.Write("No se encontraron pacientes.");
            }
        }

    }
}