<%@ Page Title="Cars" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.vb" Inherits="Taxi_AI_Website.Cars" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Seach using Tax-iD</h2>
    <h2>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Get" />
    </h2>
    <p>
        <asp:Image ID="imgCar" runat="server" Height="215px" ImageUrl="Images/Model3-Trans.png" Visible="False" Width="455px" />
        <br __designer:mapid="4a" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br __designer:mapid="12" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br __designer:mapid="14" />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br __designer:mapid="16" />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br __designer:mapid="18" />
    </p>
    </asp:Content>