﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_PERSONAL
{
    public partial class ListadoTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Tipo"] == null || (Session["Tipo"].ToString() != "02" && Session["Tipo"].ToString() != "01"))
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
    }
}