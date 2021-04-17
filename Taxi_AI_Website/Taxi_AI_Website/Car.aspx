<%@ Page Title="Car" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Car.aspx.vb" Inherits="Taxi_AI_Website.Car" %>

<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Vehicle Information</h2>
    <p>
       
&nbsp;<table style="width:100%;">
            <tr>
                <td> <asp:Image ID="Image2" runat="server" Height="357px" Width="425px" /></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
               </table>
    </p>
    <p>
        <br />
           

    </p>

    </asp:Content>