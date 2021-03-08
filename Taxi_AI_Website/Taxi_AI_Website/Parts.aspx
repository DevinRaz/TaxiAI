<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Parts.aspx.vb" Inherits="Taxi_AI_Website.Parts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Model<asp:RadioButtonList ID="RadioButtonList1" runat="server">
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
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
            <asp:TreeView ID="TreeView2" runat="server" ImageSet="Arrows">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
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
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
            <asp:TreeView ID="TreeView3" runat="server" ImageSet="Arrows">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
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
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
            <asp:TreeView ID="TreeView4" runat="server" ImageSet="Arrows">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Brakes, Steering, Suspension" Value="Brakes, Steering, Suspension">
                        <asp:TreeNode Text="Brakes" Value="Brakes">
                            <asp:TreeNode Text="Rotors" Value="Rotors"></asp:TreeNode>
                            <asp:TreeNode Text="Brake Pads &amp; Shoes" Value="Brake Pads &amp; Shoes"></asp:TreeNode>
                            <asp:TreeNode Text="Brake Calipers" Value="Brake Calipers"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
