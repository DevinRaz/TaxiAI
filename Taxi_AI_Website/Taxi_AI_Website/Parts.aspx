<%@ Page Title="Parts" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Parts.aspx.vb" Inherits="Taxi_AI_Website.Parts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <h2><%: Title %></h2>
  <%--   <div style="height:700px">

   <div style="width=30%;float:left; margin-left: 2.5%; margin-right: 2.5%;">
        <br />
<h4>
    <label>Model</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>X</asp:ListItem>
                <asp:ListItem>Y</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Air, Fuel, Emissions, &amp; Exhaust" Value="Air, Fuel, Emissions, &amp; Exhaust">
                        <asp:TreeNode Text="Filters &amp; Emissions" Value="Filters &amp; Emissions">
                            <asp:TreeNode Text="Air Filters" Value="Air Filters"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Accessories, Body, &amp; Wipers" Value="Accessories, Body, &amp; Wipers">
                        <asp:TreeNode Text="Accessories" Value="Accessories">
                            <asp:TreeNode Text="(coming soon)" Value="(coming soon)"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Wipers, Mirrors, &amp; Window Repair" Value="Wipers, Mirrors, &amp; Window Repair">
                            <asp:TreeNode Text="Wipers" Value="Wipers">
                                <asp:TreeNode Text="Wiper Arm" Value="Wiper Arm"></asp:TreeNode>
                                <asp:TreeNode Text="Wiper Blade" Value="Wiper Blade"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Electrical" Value="Electrical">
                        <asp:TreeNode Text="Lights" Value="Lights">
                            <asp:TreeNode Text="Front Lights" Value="Front Lights"></asp:TreeNode>
                            <asp:TreeNode Text="Headlamps" Value="Headlamps"></asp:TreeNode>
                            <asp:TreeNode Text="Rear Body Side Lights" Value="Rear Body Side Lights"></asp:TreeNode>
                            <asp:TreeNode Text="Rear Center Lights" Value="Rear Center Lights"></asp:TreeNode>
                            <asp:TreeNode Text="Rear License Light" Value="Rear License Light"></asp:TreeNode>
                            <asp:TreeNode Text="Rear Liftgate Light" Value="Rear Liftgate Light"></asp:TreeNode>
                            <asp:TreeNode Text="Rear Reflex Light" Value="Rear Reflex Light"></asp:TreeNode>
                            <asp:TreeNode Text="Rear Stop/Tail/Turn Light" Value="Rear Stop/Tail/Turn Light"></asp:TreeNode>
                            <asp:TreeNode Text="Turn/Fog Light" Value="Turn/Fog Light"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Brakes, Steering, Suspension" Value="Brakes, Steering, Suspension">
                        <asp:TreeNode Text="Brakes" Value="Brakes">
                            <asp:TreeNode Text="Rotors" Value="Rotors"></asp:TreeNode>
                            <asp:TreeNode Text="Brake Pads and Shoes" Value="Brake Pads and Shoes"></asp:TreeNode>
                            <asp:TreeNode Text="Brake Calipers" Value="Brake Calipers"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
    <h4 />
</div>

            <div style="left: ;">
     <br />--%>

    <h2>Seach for Parts</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Part #:"></asp:Label>
        <asp:TextBox ID="part_no" runat="server"></asp:TextBox>
 
        <asp:Label ID="Label5" runat="server" Text="Part Desc:"></asp:Label>
        <asp:TextBox ID="part_desc" runat="server"></asp:TextBox>
      
          <br />
        <asp:Label ID="Label3" runat="server" Text="Part Category:"></asp:Label>
        <asp:DropDownList ID="category" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Air Filter</asp:ListItem>
            <asp:ListItem>Brake Calipers</asp:ListItem>
            <asp:ListItem>Brake Pads and Shoes</asp:ListItem>
            <asp:ListItem>Front Lights</asp:ListItem>
            <asp:ListItem>Headlamps</asp:ListItem>
            <asp:ListItem>Rear Body Side Lights</asp:ListItem>
            <asp:ListItem>Rear Center Lights</asp:ListItem>
            <asp:ListItem>Rear License Light</asp:ListItem>
            <asp:ListItem>Rear Liftgate Light</asp:ListItem>
            <asp:ListItem>Rear Reflex Light</asp:ListItem>
            <asp:ListItem>Rear Stop/Tail/Turn Light</asp:ListItem>
            <asp:ListItem>Rotors</asp:ListItem>
            <asp:ListItem>Turn/Fog Light</asp:ListItem>
            <asp:ListItem>Wiper Arm</asp:ListItem>
            <asp:ListItem>Wiper Blade</asp:ListItem>
        </asp:DropDownList>
     
        <br />
        <asp:Label ID="Label4" runat="server" Text="Compatible Model:"></asp:Label>
        <asp:DropDownList ID="compatible_model" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>S</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>X</asp:ListItem>
            <asp:ListItem>Y</asp:ListItem>
        </asp:DropDownList>
      
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Get" />
           
              <asp:GridView ID="gvParts" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Height="98px" Width="1318px">
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                           <Columns>
     <asp:BoundField DataField = "part_no" HeaderText = "Part No" />
     <asp:BoundField DataField = "part_summary" HeaderText = "Part Summary" />
     <asp:BoundField DataField = "part_description" HeaderText = "Part Description" />
     <asp:BoundField DataField = "qty" HeaderText = "Quantity" />
                                    <asp:BoundField DataField = "manufacturer" HeaderText = "Manufacturer" />
                                    <asp:BoundField DataField = "store_id" HeaderText = "Store ID" />
                                    <asp:BoundField DataField = "compatible_model" HeaderText = "Model" />
                                    <asp:BoundField DataField = "part_id" HeaderText = "Part ID" />
                                    <asp:BoundField DataField = "category" HeaderText = "Category" />
  </Columns>

                    </asp:GridView>


</asp:Content>