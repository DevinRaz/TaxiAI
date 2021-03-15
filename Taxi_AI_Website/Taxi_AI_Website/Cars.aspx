<%@ Page Title="Cars" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.vb" Inherits="Taxi_AI_Website.Cars" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h2>Seach using TaxiD</h2>
    <h2>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Get" />
    </h2>
    <p>
        &nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" Height="457px">
        <asp:Image ID="imgCar" runat="server" Height="215px" ImageUrl="Images/Model3-Trans.png" Visible="False" Width="455px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </asp:Panel>
    </asp:Content>