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
    public partial class AgregarMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProvincias();
                cargarLocalidades(ddlProvincias.SelectedValue);
                cargarEspecialidades();
            }
        }
        protected void cargarProvincias()
        {
            {
                NegocioProvincia negocio = new NegocioProvincia();
                List<Provincia> provincias = negocio.GetProvincias();

                ddlProvincias.DataSource = provincias;
                ddlProvincias.DataTextField = "Nombre";
                ddlProvincias.DataValueField = "idProvincia";
                ddlProvincias.DataBind();

                ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione una provincia --", "0"));
            }
        }
        protected void cargarLocalidades(string provincia)
        {
            {
                NegocioLocalidad negocioLocalidad = new NegocioLocalidad();
                List<Localidad> localidades = negocioLocalidad.GetLocalidades(provincia);

                ddlLocalidades.DataSource = localidades;
                ddlLocalidades.DataTextField = "Nombre";
                ddlLocalidades.DataValueField = "idLocalidad";
                ddlLocalidades.DataBind();

                ddlLocalidades.Items.Insert(0, new ListItem("-- Seleccione una localidad --", "0"));
            }
        }

        protected void ddlProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades(ddlProvincias.SelectedValue);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ddlProvincias.SelectedValue = "0";
            ddlLocalidades.SelectedValue = "0";
            txtFechaNac.Text = String.Empty;
            ddlEspecialidades.SelectedValue = "0";
        }

        protected void cargarEspecialidades()
        {
            {
                NegocioEspecialidad negocio = new NegocioEspecialidad();
                List<Especialidad> especialidades = negocio.GetEspecialidades();

                ddlEspecialidades.DataSource = especialidades;
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataValueField = "codEspecialidad";
                ddlEspecialidades.DataBind();

                ddlEspecialidades.Items.Insert(0, new ListItem("-- Seleccione una especialidad --", "0"));
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Medico m = new Medico();

            m.DNI = txtDni.Text.Trim();
            m.Nombre = txtNombre.Text.Trim();
            m.Apellido = txtApellido.Text.Trim();
            m.Tipo = "02";
            m.Email = txtEmail.Text.Trim();
            m.Nacionalidad =  txtNacionalidad.Text.Trim();
            m.Direccion = txtDireccion.Text.Trim();
            m.Localidad = ddlLocalidades.SelectedValue;
            m.Provincia = ddlProvincias.SelectedValue;
            m.Horario = txtHorario.Text.Trim();
            m.Telefono = txtTelefono.Text.Trim();
            m.Especialidad = ddlEspecialidades.SelectedValue;
            m.Username = txtUsername.Text.Trim();
            m.Password = txtPassword.Text.Trim();

            // TODO: CARGAR EN LA BASE DE DATOS
        }
    }
}