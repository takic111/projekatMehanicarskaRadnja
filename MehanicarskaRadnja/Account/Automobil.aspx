<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Automobil.aspx.cs" Inherits="MehanicarskaRadnja.Account.Automobil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Unos automobila</h1>
    <asp:Label ID="Label1" runat="server" Text="Marka:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Model:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Vrsta usluge:"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Unesi automobil" CssClass="btn btn-primary" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
</asp:Content>
