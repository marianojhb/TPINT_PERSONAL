<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMedico.aspx.cs" Inherits="TPINT_PERSONAL.AgregarMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
.form-check-input {
    border: none !important;
    box-shadow: none;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
            <h2>Agregar Médico</h2>

                

<div class="container" style="max-width: 700px;">
  <div class="form-group row">

    <label for="txtDni" class="col-sm-4 col-form-label">DNI</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" placeholder="DNI" />
    </div>

    <label for="txtNombre" class="col-sm-4 col-form-label">Nombre</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" />
    </div>

    <label for="txtApellido" class="col-sm-4 col-form-label">Apellido</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido" />
    </div>

  <fieldset class="form-group">
    <div class="row">
     
      
     
      <legend class="col-form-label col-sm-4 pt-0">Sexo</legend>
      <div class="col-sm-8">
        <div class="form-check form-check-inline">
            <asp:RadioButton ID="rbMasculino" CssClass="form-check-input" GroupName="Sexo" value="M" Text="Masculino" runat="server" />
          <label class="form-check-label" for="rbMasculino">
            Masculino
          </label>
        </div>
        <div class="form-check form-check-inline">
            <asp:RadioButton ID="rbFemenino" CssClass="form-check-input" GroupName="Sexo" value="F" Text="Femenino" runat="server" />
            <label class="form-check-label" for="rbFemenino">
            Femenino
          </label>
        </div>
      </div>
    </div>
   
  </fieldset>


    <label for="txtNacionalidad" class="col-sm-4 col-form-label">Nacionalidad</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="form-control" placeholder="Nacionalidad" />
    </div>

    <label for="ddlProvincias" class="col-sm-4 col-form-label">Provincia</label>
    
    <div class="col-sm-8">
        <asp:DropDownList ID="ddlProvincias" runat="server" CssClass="form-select" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincias_SelectedIndexChanged" >
    </asp:DropDownList>
      </div>   

    <label for="ddlLocalidades" class="col-sm-4 col-form-label">Localidad</label>
        <div class="col-sm-8">
        <asp:DropDownList ID="ddlLocalidades" runat="server" CssClass="form-select" AutoPostBack="true" >
            </asp:DropDownList>
        </div>

   

            <label for="txtFechaNac"  class="col-sm-4 col-form-label">Fecha de Nacimiento</label>
        <div class="col-sm-8">
            <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form-control datepicker" placeholder="Fecha de Nacimiento" style="padding: 7px 12px;"/>
            
        </div>

   

    <label for="txtDireccion" class="col-sm-4 col-form-label">Dirección</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Calle número y departamento" />
    </div>
   

    <label for="txtEmail" class="col-sm-4 col-form-label">Email</label>
    <div class="col-sm-8">
        <asp:TextBox TextMode="Email" ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" />

    </div>



    <label for="txtTelefono" class="col-sm-4 col-form-label">Telefono</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Telefono" />
    </div>

    <label for="txtHorario" class="col-sm-4 col-form-label">Horario</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtHorario" runat="server" CssClass="form-control" placeholder="Horario" />
    </div>

    <label for="ddlEspecialidades" class="col-sm-4 col-form-label">Especialidad</label>
    
    <div class="col-sm-8">
        <asp:DropDownList ID="ddlEspecialidades" runat="server" CssClass="form-select" >
    </asp:DropDownList>
      </div>   


    <label for="txtUsername" class="col-sm-4 col-form-label">Nombre de usuario</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" />
    </div>

    <label for="txtPassword" class="col-sm-4 col-form-label">Contraseña</label>
    <div class="col-sm-8">
        <asp:TextBox TextMode="Password" ID="txtPassword" runat="server" CssClass="form-control" placeholder="Contraseña" aria-describedby="passwordHelpBlock" autocomplete="new-password"/>
        <small id="passwordHelpBlock" class="form-text text-muted">
            La contraseña debe tener entre 8 y 20 caracteres, contener letra y números, sin espacios, caracteres especiales o emoji.</small>
    </div>

    <label for="txtImagenURL" class="col-sm-4 col-form-label">Imagen</label>
    <div class="col-sm-8">
        <asp:FileUpload ID="fuImagenURL" runat="server" CssClass="form-control" />
    </div>


    <%--botones limpiar y guardar--%>
    <div class="form-group row">
      <div class="col-sm-12 text-center mt-3">
        <asp:Button ID="btnReset" runat="server" CssClass="btn btn-secondary mx-2" Text="Limpiar" OnClick="btnReset_Click" />
        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary mx-2" Text="Guardar" OnClick="btnGuardar_Click" />
      </div>
</div>
</div>

</div> <%--endform --%>

    <script>
    $(document).ready(function () {
        $('.datepicker').datepicker({
            format: 'yyyy-mm-dd',
            autoclose: true,
            todayHighlight: true
        });
    });
    </script>
</asp:Content>
