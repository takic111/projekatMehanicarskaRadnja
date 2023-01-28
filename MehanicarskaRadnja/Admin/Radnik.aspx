<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Radnik.aspx.cs" Inherits="MehanicarskaRadnja.Account.Radnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Unesi radnika</h1>
    <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Prezime"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Plata:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Unesi radnika" CssClass="btn btn-danger" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Bold="true" ForeColor="Red" Text=""></asp:Label>
</asp:Content>
