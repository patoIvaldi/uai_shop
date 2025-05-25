<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>UAI SHOP</h1>
        <p>&nbsp;</p>
        <p>Iniciar Sesion</p>
        <p>Usuario</p>
        <asp:TextBox ID="TextBox1User" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña<br />
        <br />
        <asp:TextBox ID="TextBox2pass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" Height="26px" OnClick="ButtonLogin_Click" Text="Ingresar" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    </div>
</asp:Content>
