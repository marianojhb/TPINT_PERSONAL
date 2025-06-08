<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medico.aspx.cs" Inherits="TPINT_PERSONAL.Medico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Pagina de usuario Medico</h2>
    <asp:Button ID="btnAgregarPaciente" runat="server" Text="Agregar Paciente" OnClick="btnAgregarPaciente_Click" />
</asp:Content>
