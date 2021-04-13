<%@ Page Title="Cars" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.vb" Inherits="Taxi_AI_Website.Cars" %>

<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Search for a Car</h2>
    <p>
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
        <br />
           
              <asp:GridView ID="gvVehicles" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Height="98px" Width="1318px">
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                           <Columns>
     <asp:BoundField DataField = "id" HeaderText = "TaxID" />
     <asp:BoundField DataField = "vin" HeaderText = "VIN" />
     <asp:BoundField DataField = "make" HeaderText = "Make" />
     <asp:BoundField DataField = "model" HeaderText = "Model" />
                                    <asp:BoundField DataField = "color" HeaderText = "Color" />
                                    <asp:BoundField DataField = "plate" HeaderText = "Plate" />
                                    <asp:BoundField DataField = "location" HeaderText = "Location" />
                                    <asp:BoundField DataField = "battery" HeaderText = "Battery Level" />
                                    <asp:BoundField DataField = "status" HeaderText = "Status" />
                               <asp:BoundField DataField = "odometer" HeaderText = "Odometer" />
  </Columns>

                    </asp:GridView>


    </p>

    </asp:Content>