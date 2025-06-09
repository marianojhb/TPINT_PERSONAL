using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class ListadoMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                if (Session["Tipo"] == null || (Session["Tipo"].ToString() != "02" && Session["Tipo"].ToString() != "01"))
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarMedico.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }

        protected void lvListadoMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lvListadoMedicos_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                var dataItem = (DataRowView)e.Item.DataItem;

                DropDownList ddlProvincias = (DropDownList)e.Item.FindControl("ddlProvincias");

                if (ddlProvincias != null)
                {
                    // Cargar provincias
                    NegocioProvincia negocioProvincia = new NegocioProvincia();
                    List<Provincia> provincias = negocioProvincia.GetProvincias();

                    ddlProvincias.DataSource = provincias;
                    ddlProvincias.DataTextField = "Nombre";
                    ddlProvincias.DataValueField = "idProvincia";
                    ddlProvincias.DataBind();

                    // Seleccionar valor actual
                    int idProvinciaActual = Convert.ToInt32(dataItem["idProvincia_U"]);
                    ListItem item = ddlProvincias.Items.FindByValue(idProvinciaActual.ToString());
                    if (item != null)
                    {
                        ddlProvincias.ClearSelection();
                        item.Selected = true;
                    }
                }
            }
        }


    }

}