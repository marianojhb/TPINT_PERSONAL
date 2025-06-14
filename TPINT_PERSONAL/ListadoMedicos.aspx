﻿<%@ Page Title="Listado de Médicos | TUP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoMedicos.aspx.cs" Inherits="TPINT_PERSONAL.ListadoMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        th {
            text-align:center !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>LISTADO MEDICOS</h2>
    <asp:Button ID="btnAgregarMedico" runat="server" Text="Agregar Médico" OnClick="btnAgregarMedico_Click" Visible="False" />
    <asp:ListView ID="lvListadoMedicos" runat="server" DataKeyNames="dni_U,codEspecialidad_E,idLocalidad_L,idProvincia_L,idProvincia_P" DataSourceID="sdsListadoMedicos" OnSelectedIndexChanged="lvListadoMedicos_SelectedIndexChanged" OnItemDataBound="lvListadoMedicos_ItemDataBound">
        <EditItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                </td>
                <td>
                    <asp:TextBox ID="imagen_UTextBox" runat="server" Text='<%# Bind("imagen_U") %>' />
                </td>
                <td>
                    <asp:Label ID="dni_ULabel1" runat="server" Text='<%# Eval("dni_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="nombre_UTextBox" runat="server" Text='<%# Bind("nombre_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="apellido_UTextBox" runat="server" Text='<%# Bind("apellido_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="tipo_UTextBox" runat="server" Text='<%# Bind("tipo_U") %>' />
                </td>
                <td>
                    <%--<asp:TextBox ID="sexo_UTextBox" runat="server" Text='<%# Bind("sexo_U") %>' />--%>
                    <asp:DropDownList ID="ddlSexo" runat="server"  Text='<%# Bind("sexo_U") %>'>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Femenino</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="nacionalidad_UTextBox" runat="server" Text='<%# Bind("nacionalidad_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="fechaNac_UTextBox" runat="server" CssClass="form-control datepicker" placeholder="Fecha de Nacimiento" style="padding: 7px 12px;" Text='<%# Bind("fechaNac_U") %>'/>
                </td>
                <td>
                    <asp:TextBox ID="direccion_UTextBox" runat="server" Text='<%# Bind("direccion_U") %>' />
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidades" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <%--<asp:TextBox ID="nombre_PTextBox" runat="server" Text='<%# Bind("nombre_P") %>' />--%>

                    <asp:DropDownList ID="ddlProvincias" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincias_SelectedIndexChanged"></asp:DropDownList>
                </td>
<%--                <td>
                    <asp:TextBox ID="idLocalidad_UTextBox" runat="server" Text='<%# Bind("idLocalidad_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="idProvincia_UTextBox" runat="server" Text='<%# Bind("idProvincia_U") %>' />
                </td>--%>
                <td>
                    <asp:TextBox ID="email_UTextBox" runat="server" Text='<%# Bind("email_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="telefono_UTextBox" runat="server" Text='<%# Bind("telefono_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="legajo_UTextBox" runat="server" Text='<%# Bind("legajo_U") %>' />
                </td>
<%--                <td>
                    <asp:TextBox ID="codEspecialidad_UTextBox" runat="server" Text='<%# Bind("codEspecialidad_U") %>' />
                </td>--%>
                <td>
                    <asp:TextBox ID="horario_UTextBox" runat="server" Text='<%# Bind("horario_U") %>' />
                </td>
<%--            <td>
                    <asp:Label ID="codEspecialidad_ELabel1" runat="server" Text='<%# Eval("codEspecialidad_E") %>' />
                </td>--%>
 <%--           <td>
                    <asp:Label ID="idLocalidad_LLabel1" runat="server" Text='<%# Eval("idLocalidad_L") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_LLabel1" runat="server" Text='<%# Eval("idProvincia_L") %>' />
                </td>--%>
<%--                <td>
                    <asp:Label ID="idProvincia_PLabel1" runat="server" Text='<%# Eval("idProvincia_P") %>' />
                </td>--%>
                <td>
                    <asp:TextBox ID="nombre_ETextBox" runat="server" Text='<%# Bind("nombre_E") %>' />
                </td>
                <td>
                    <asp:TextBox ID="usuario_UTextBox" runat="server" Text='<%# Bind("usuario_U") %>' />
                </td>
                <td>
                    <asp:TextBox ID="password_UTextBox" runat="server" Text='<%# Bind("password_U") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="estado_UCheckBox" runat="server" Checked='<%# Bind("estado_U") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>No se han devuelto datos.</td>
                </tr>
            </table>
        </EmptyDataTemplate>

        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:LinkButton ID="DeleteButton" runat="server" CssClass="btn btn-danger" CommandName="Delete" >Eliminar</asp:LinkButton>
                    <asp:LinkButton ID="EditButton" runat="server" CssClass="btn btn-secondary" CommandName="Edit" >Editar</asp:LinkButton>
                    
                </td>
                <td>
                    <img src='<%# Eval("imagen_U") %>' width="50" class="img-fluid rounded-circle"/> <br />  
                    
                </td>
                <td>
                    <asp:Label ID="dni_ULabel" runat="server" Text='<%# Eval("dni_U") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_ULabel" runat="server" Text='<%# Eval("nombre_U") %>' />
                </td>
                <td>
                    <asp:Label ID="apellido_ULabel" runat="server" Text='<%# Eval("apellido_U") %>' />
                </td>
                <td>
                    <asp:Label ID="tipo_ULabel" runat="server" Text='<%# Eval("tipo_U") %>' />
                </td>
                <td>
                    <asp:Label ID="sexo_ULabel" runat="server" Text='<%# Eval("sexo_U") %>' />
                </td>
                <td>
                    <asp:Label ID="nacionalidad_ULabel" runat="server" Text='<%# Eval("nacionalidad_U") %>' />
                </td>
                <td>
                    <asp:Label ID="fechaNac_ULabel" runat="server" Text='<%# Eval("fechaNac_U", "{0:dd/MM/yyyy}") %>' />
                </td>
                <td>
                    <asp:Label ID="direccion_ULabel" runat="server" Text='<%# Eval("direccion_U") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_LLabel" runat="server" Text='<%# Eval("nombre_L") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_PLabel" runat="server" Text='<%# Eval("nombre_P") %>' />
                </td>
<%--            <td>
                    <asp:Label ID="idLocalidad_ULabel" runat="server" Text='<%# Eval("idLocalidad_U") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_ULabel" runat="server" Text='<%# Eval("idProvincia_U") %>' />
                </td>--%>
                <td>
                    <asp:Label ID="email_ULabel" runat="server" Text='<%# Eval("email_U") %>' />
                </td>
                <td>
                    <asp:Label ID="telefono_ULabel" runat="server" Text='<%# Eval("telefono_U") %>' />
                </td>
                <td>
                    <asp:Label ID="legajo_ULabel" runat="server" Text='<%# Eval("legajo_U") %>' />
                </td>
<%--                <td>
                    <asp:Label ID="codEspecialidad_ULabel" runat="server" Text='<%# Eval("codEspecialidad_U") %>' />
                </td>--%>
                <td>
                    <asp:Label ID="horario_ULabel" runat="server" Text='<%# Eval("horario_U") %>' />
                </td>
<%--                <td>
                    <asp:Label ID="codEspecialidad_ELabel" runat="server" Text='<%# Eval("codEspecialidad_E") %>' />
                </td>--%>
                <td>
                    <asp:Label ID="nombre_ELabel" runat="server" Text='<%# Eval("nombre_E") %>' />
                </td>
<%--                <td>
                    <asp:Label ID="idLocalidad_LLabel" runat="server" Text='<%# Eval("idLocalidad_L") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_LLabel" runat="server" Text='<%# Eval("idProvincia_L") %>' />
                </td>--%>
<%--                <td>
                    <asp:Label ID="idProvincia_PLabel" runat="server" Text='<%# Eval("idProvincia_P") %>' />
                </td>--%>
                <td>
                    <asp:Label ID="usuario_ULabel" runat="server" Text='<%# Eval("usuario_U") %>' />
                </td>
                <td>
                    <asp:Label ID="password_ULabel" runat="server" Text='<%# Eval("password_U") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="estado_UCheckBox" runat="server" Checked='<%# Eval("estado_U") %>' Enabled="false" />
                </td>
            </tr>
        </ItemTemplate>
    <LayoutTemplate>
        <table runat="server" class="table table-striped table-bordered">
            <thead>
                <tr>
                    <th>Acciones</th>
                    <th>Imagen</th>
                    <th>DNI</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Tipo</th>
                    <th>Sexo</th>
                    <th>Nacionalidad</th>
                    <th>Fecha de<br />
                        Nacimiento</th>
                    <th>Dirección</th>
                    <th>Localidad</th>
                    <th>Provincia</th>
                    <th>Email</th>
                    <th>Teléfono</th>
                    <th>Legajo</th>
                    <th>Horario</th>
                    <th>Especialidad</th>
                    <th>Usuario</th>
                    <th>Contraseña</th>
                    <th>Estado</th>
                </tr>
            </thead>
            <tbody>
                <tr runat="server" id="itemPlaceholder"></tr>
            </tbody>
        </table>
        <asp:DataPager ID="DataPager1" runat="server">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
            </Fields>
        </asp:DataPager>
    </LayoutTemplate>


        <SelectedItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
                </td>
                <td>
                    <asp:Label ID="dni_ULabel" runat="server" Text='<%# Eval("dni_U") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_ULabel" runat="server" Text='<%# Eval("nombre_U") %>' />
                </td>
                <td>
                    <asp:Label ID="apellido_ULabel" runat="server" Text='<%# Eval("apellido_U") %>' />
                </td>
                <td>
                    <asp:Label ID="tipo_ULabel" runat="server" Text='<%# Eval("tipo_U") %>' />
                </td>
                <td>
                    <asp:Label ID="usuario_ULabel" runat="server" Text='<%# Eval("usuario_U") %>' />
                </td>
                <td>
                    <asp:Label ID="sexo_ULabel" runat="server" Text='<%# Eval("sexo_U") %>' />
                </td>
                <td>
                    <asp:Label ID="nacionalidad_ULabel" runat="server" Text='<%# Eval("nacionalidad_U") %>' />
                </td>
                <td>
                    <asp:Label ID="fechaNac_ULabel" runat="server" Text='<%# Eval("fechaNac_U") %>' />
                </td>
                <td>
                    <asp:Label ID="direccion_ULabel" runat="server" Text='<%# Eval("direccion_U") %>' />
                </td>
                <td>
                    <asp:Label ID="idLocalidad_ULabel" runat="server" Text='<%# Eval("idLocalidad_U") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_ULabel" runat="server" Text='<%# Eval("idProvincia_U") %>' />
                </td>
                <td>
                    <asp:Label ID="email_ULabel" runat="server" Text='<%# Eval("email_U") %>' />
                </td>
                <td>
                    <asp:Label ID="telefono_ULabel" runat="server" Text='<%# Eval("telefono_U") %>' />
                </td>
                <td>
                    <asp:Label ID="legajo_ULabel" runat="server" Text='<%# Eval("legajo_U") %>' />
                </td>
                <td>
                    <asp:Label ID="codEspecialidad_ULabel" runat="server" Text='<%# Eval("codEspecialidad_U") %>' />
                </td>
                <td>
                    <asp:Label ID="horario_ULabel" runat="server" Text='<%# Eval("horario_U") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="estado_UCheckBox" runat="server" Checked='<%# Eval("estado_U") %>' Enabled="false" />
                </td>
                <td>
                    <asp:Label ID="password_ULabel" runat="server" Text='<%# Eval("password_U") %>' />
                </td>
                <td>
                    <asp:Label ID="imagen_ULabel" runat="server" Text='<%# Eval("imagen_U") %>' />
                </td>
                <td>
                    <asp:Label ID="codEspecialidad_ELabel" runat="server" Text='<%# Eval("codEspecialidad_E") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_ELabel" runat="server" Text='<%# Eval("nombre_E") %>' />
                </td>
                <td>
                    <asp:Label ID="idLocalidad_LLabel" runat="server" Text='<%# Eval("idLocalidad_L") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_LLabel" runat="server" Text='<%# Eval("idProvincia_L") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_LLabel" runat="server" Text='<%# Eval("nombre_L") %>' />
                </td>
                <td>
                    <asp:Label ID="idProvincia_PLabel" runat="server" Text='<%# Eval("idProvincia_P") %>' />
                </td>
                <td>
                    <asp:Label ID="nombre_PLabel" runat="server" Text='<%# Eval("nombre_P") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
</asp:ListView>
    <asp:SqlDataSource ID="sdsListadoMedicos" runat="server" ConnectionString="<%$ ConnectionStrings:TPINT_PERSONALConnectionString %>" 
            SelectCommand="SELECT * FROM USUARIOS U
            INNER JOIN
            ESPECIALIDADES E
            ON E.codEspecialidad_E = U.codEspecialidad_U
            INNER JOIN
            LOCALIDADES L
            ON U.idLocalidad_U = L.idLocalidad_L
            INNER JOIN
            PROVINCIAS P
            ON L.idProvincia_L = P.idProvincia_P"
        UpdateCommand="UPDATE Usuarios SET nombre_U = @nombre_U, apellido_U = @apellido_U, tipo_U = @tipo_U, usuario_U = @usuario_U, sexo_U = @sexo_U, nacionalidad_U = @nacionalidad_U, fechaNac_U = @fechaNac_U, direccion_U = @direccion_U, idLocalidad_U = @idLocalidad_U, idProvincia_U = @idProvincia_U, email_U = @email_U, telefono_U = @telefono_U, legajo_U = @legajo_U, codEspecialidad_U = @codEspecialidad_U, horario_U = @horario_U, estado_U = @estado_U, password_U = @password_U WHERE dni_U = @dni_U"
    DeleteCommand="UPDATE USUARIOS SET estado_U = 0 FROM Usuarios WHERE dni_U = @dni_U">

    </asp:SqlDataSource>

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
