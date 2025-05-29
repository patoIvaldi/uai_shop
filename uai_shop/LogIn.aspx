<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="background-color: #652C35; height: 50px;">&nbsp;</h1>
        <h1>
            <asp:Image ID="Image1" runat="server" Height="162px" ImageUrl="~/fonts/uaishop.jpg" Width="281px" />
        </h1>
        <p>Iniciar Sesion</p>
        <p>Usuario</p>
        <asp:TextBox ID="TextBox1User" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1User" ErrorMessage="Debe completar el campo"></asp:RequiredFieldValidator>
        <br />
        <br />
        <p>Contraseña</p>
        <asp:TextBox ID="TextBox2pass" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2pass" ErrorMessage="Debe completar el campo"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" Height="26px" OnClick="ButtonLogin_Click" Text="Ingresar" Width="126px" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    </div>
</asp:Content>
