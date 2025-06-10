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
            if ( Session["Tipo"] == null || (Session["Tipo"].ToString() != "02" && Session["Tipo"].ToString() != "01") )
            {
                Response.Redirect("~/Login.aspx");
            }

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
                NegocioProvincia negocioProvincia = new NegocioProvincia();
                List<Provincia> provincias = negocioProvincia.GetProvincias();

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
            txtDni.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtNacionalidad.Text = String.Empty;
            txtFechaNac.Text = String.Empty;
            txtHorario.Text = String.Empty; 
            ddlEspecialidades.SelectedValue = "0";
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            txtDireccion.Text = String.Empty;
            ddlProvincias.SelectedValue = "0";
            ddlLocalidades.SelectedValue = "0";
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;    
            
        }

        protected void cargarEspecialidades()
        {
            {
                NegocioEspecialidad negocioEspecialidad = new NegocioEspecialidad();
                List<Especialidad> especialidades = negocioEspecialidad.GetEspecialidades();

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

            // Radio button de Sexo:
            {
                string sexoSeleccionado = "";
                if (rbMasculino.Checked)
                    sexoSeleccionado = "M";
                else if (rbFemenino.Checked)
                    sexoSeleccionado = "F";
                m.Sexo = sexoSeleccionado[0];
            }
            m.Email = txtEmail.Text.Trim();
            m.Nacionalidad =  txtNacionalidad.Text.Trim();
            m.FechaNac = txtFechaNac.Text.Trim();
            m.Direccion = txtDireccion.Text.Trim();
            m.IdLocalidad = Convert.ToInt32(ddlLocalidades.SelectedValue);
            m.IdProvincia = Convert.ToInt32(ddlProvincias.SelectedValue);
            m.Horario = txtHorario.Text.Trim();
            m.Telefono = txtTelefono.Text.Trim();
            m.CodEspecialidad = Convert.ToInt32(ddlEspecialidades.SelectedValue);
            m.Username = txtUsername.Text.Trim();
            m.Password = txtPassword.Text.Trim();
            m.Imagen = fuImagenURL?.HasFile == true ? "~/imagenes/perfiles/" + fuImagenURL.FileName : m.Imagen; // operador ternario doble

            // TODO: CARGAR EN LA BASE DE DATOS
            NegocioMedico negocioMedico = new NegocioMedico();
            int insercionOK = negocioMedico.AgregarMedico(m);

            if (insercionOK == 1)
            {
                Response.Redirect("ListadoMedicos.aspx");
            }
            else
            {

            }
            
        }
    }
}