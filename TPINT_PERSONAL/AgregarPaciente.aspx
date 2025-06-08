<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="TPINT_PERSONAL.AgregarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Agregar Paciente</h2>

                

<div class="container" style="max-width: 700px;">
  <div class="form-group row">

    <label for="txtNombre" class="col-sm-4 col-form-label">Nombre</label>
    <div class="col-sm-8">
        <input type="text" class="form-control" id="txtNombre" placeholder="Nombre">
    </div>

    <label for="txtApellido" class="col-sm-4 col-form-label">Apellido</label>
    <div class="col-sm-8">
        <input type="text" class="form-control" id="txtApellido" placeholder="Apellido">
    </div>

    <label for="txtDni" class="col-sm-4 col-form-label">DNI</label>
    <div class="col-sm-8">
        <input type="text" class="form-control" id="txtDni" placeholder="DNI">
    </div>

  <fieldset class="form-group">
    <div class="row">
      <legend class="col-form-label col-sm-4 pt-0">Sexo</legend>
      <div class="col-sm-8">
        <div class="form-check">
          <input class="form-check-input" type="radio" name="radioSexo" id="gridMasculino" value="M">
          <label class="form-check-label" for="gridRadios1">
            Masculino
          </label>
        </div>
        <div class="form-check">
          <input class="form-check-input" type="radio" name="radioSexo" id="gridFemenino" value="F">
          <label class="form-check-label" for="gridRadios2">
            Femenino
          </label>
        </div>
      </div>
    </div>
  </fieldset>


    <label for="txtNacionalidad" class="col-sm-4 col-form-label">Nacionalidad</label>
    <div class="col-sm-8">
        <input type="text" class="form-control" id="txtNacionalidad" placeholder="Nacionalidad">
    </div>
 



   

            <label for="txtFechaNac"  class="col-sm-4 col-form-label">Fecha de Nacimiento</label>
        <div class="col-sm-8">
            <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form-control datepicker" placeholder="Fecha de Nacimiento" />
        </div>

   

    <label for="txtEmail" class="col-sm-4 col-form-label">Email</label>
    <div class="col-sm-8">
        <input type="email" class="form-control" id="txtEmail" placeholder="Email">
    </div>


    <label for="txtTelefono" class="col-sm-4 col-form-label">Telefono</label>
    <div class="col-sm-8">
        <input type="text" class="form-control" id="txtTelefono" placeholder="Telefono">
    </div>


  <div class="form-group row">
    <div class="col-sm-2">Checkbox</div>
    <div class="col-sm-10">
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="gridCheck1">
        <label class="form-check-label" for="gridCheck1">
          Example checkbox
        </label>
      </div>
    </div>
  </div>


  <div class="form-group row">
    <div class="col-sm-10">
      <button type="submit" class="btn btn-primary">Guardar</button>
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
