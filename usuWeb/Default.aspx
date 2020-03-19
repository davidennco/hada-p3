<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Página de usuarios</h1>
    </div>
    <div>
        NIF:
        <asp:TextBox ID="NIF" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Nombre:
        <asp:TextBox ID="Nombre" runat="server" Width="173px"></asp:TextBox>        
        <br />
        <br />
        Edad:
        <asp:TextBox ID="Edad" runat="server" Width="173px"></asp:TextBox>
        <br />
        <asp:Button ID="Leer" runat="server" Text="Leer" OnClick="Leer_Click" />
        &nbsp;
        <asp:Button ID="Leer_Primero" runat="server" Text="Leer Primero" />
        &nbsp;
        <asp:Button ID="Leer_Anterior" runat="server" Text="Leer Anterior" />
        &nbsp;
        <asp:Button ID="Leer_Siguiente" runat="server" Text="Leer Siguiente" />
        &nbsp;
        <asp:Button ID="Crear" runat="server" Text="Crear" />
        &nbsp;
        <asp:Button ID="Actualizar" runat="server" Text="Actualizar" />
        &nbsp;
        <asp:Button ID="Borrar" runat="server" Text="Borrar" />
    </div>
</asp:Content>

