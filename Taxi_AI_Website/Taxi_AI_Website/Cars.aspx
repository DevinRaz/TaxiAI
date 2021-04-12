<%@ Page Title="Cars" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.vb" Inherits="Taxi_AI_Website.Cars" %>

<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Search for a Car</h2>
    <h2>
        <asp:Label ID="Label5" runat="server" Text="Taxi-ID:"></asp:Label>
        <asp:TextBox ID="id" runat="server"></asp:TextBox> <br />
        <asp:Label ID="Label6" runat="server" Text="VIN:"></asp:Label>
        <asp:TextBox ID="vin" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label10" runat="server" Text="License Plate #:"></asp:Label>
        <asp:TextBox ID="plate" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="Make:"></asp:Label>
        <asp:DropDownList ID="make" runat="server">
            <asp:ListItem Selected="True">Tesla</asp:ListItem>
        </asp:DropDownList> <br />
        <asp:Label ID="Label8" runat="server" Text="Model:"></asp:Label>
        <asp:DropDownList ID="model" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>S</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>X</asp:ListItem>
            <asp:ListItem>Y</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="Label9" runat="server" Text="Color:"></asp:Label>
        <asp:TextBox ID="color" runat="server"></asp:TextBox> <br />


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