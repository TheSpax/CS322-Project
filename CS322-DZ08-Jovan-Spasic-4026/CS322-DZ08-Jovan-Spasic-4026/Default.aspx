<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS322_DZ08_Jovan_Spasic_4026._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CS322 - DZ08</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Faktorijel broja</h2>
            <p>Izracunajte faktorijel nekog broja</p>
            <asp:Label ID="Label1" runat="server" Text="Unesite broj"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Racunaj" OnClick="Button1_Click"/><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Faktorijel broja je: "></asp:Label><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </div>

</asp:Content>
