<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PregledPodataka.aspx.cs" Inherits="MehanicarskaRadnja.Admin.PregledPodataka" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Pregled podataka</h1>
    <p>
        U ovoj sekciji mozete da oznacite uradjene poslove i da vidite cenovnik usluga.
    </p>
    <div>
        <h3>Automobili u garazi</h3>
        <asp:GridView ID="GridView1" runat="server" CssClass="table" Width="40%" AutoGenerateSelectButton="true"></asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Zavrsi popravku" CssClass="btn btn-success" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    </div>
    <div>
        <h3>Cenovnik</h3>
        <asp:GridView ID="GridView2" runat="server" CssClass="table" Width="40%"></asp:GridView>
    </div>
    <div>
        <h3>Spisak radnika</h3>
        <asp:GridView ID="GridView3" runat="server" CssClass="table" Width="40%" AutoGenerateSelectButton="true"></asp:GridView>
        <asp:Button ID="Button2" runat="server" Text="Daj otkaz" CssClass="btn btn-danger" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    </div>
</asp:Content>
