<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="GovernmentRefund.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="text-center">
    <div class="page-title">

        <h1> Add User </h1>
        <br /> 
    </div>

    <table align="center">
        <tr>
            <td>
<%-- <input class="input-fieldd" id="UserNamee" name="UserName" placeholder=" Enter user Name" type="text" />--%>
     <asp:TextBox class="input-fieldd" ID="UserNamee"  placeholder=" Enter user Namee" runat="server"></asp:TextBox>
            </td>
        </tr>

                <tr>
            <td>
<%--    <input class="input-fieldd" id="ID" name="ID" placeholder=" Enter user ID" type="text" />--%>
     <asp:TextBox class="input-fieldd" ID="UserID"  placeholder=" Enter user ID" runat="server"></asp:TextBox>
            </td>
        </tr>

                <tr>
            <td>
<%--    <input class="input-fieldd" id="Password" name="Password" placeholder=" Enter User password " type="password" />--%>

         <asp:TextBox class="input-fieldd" ID="Password"  placeholder=" Enter User password" type="password" runat="server"></asp:TextBox>
                

            </td>
        </tr>
    </table>
    <h6 style="text-align:center; color: white; font-size:large ;font-family:'Times New Roman', Times, serif"> Role: </h6>
<%--    <select name="RoleID" style="font-family: 'Times New Roman', Times, serif" id="dropdown" required>
        <option value="" disabled selected hidden>Please Select</option>
        <option value="101">Admin</option>
        <option value="102">Sales Office</option>
        <option value="103">Pax</option>
        <option value="104">Collection Team</option>
    </select>--%>

    <asp:DropDownList ID="RoleID" runat="server">
            <asp:ListItem>Please Select: </asp:ListItem>  
            <asp:ListItem value="101">Admin </asp:ListItem>  
            <asp:ListItem value="102">Sales </asp:ListItem>  
            <asp:ListItem value="103">Pax </asp:ListItem>  
            <asp:ListItem value="104">Collection Team</asp:ListItem>  
    </asp:DropDownList>

    <br /> <br />

<%--        <a href="AdminDashboard.aspx" class="btn btn-primary btn-lg active" role="button">Search</a>--%>
    <asp:Button class="my-button" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />

<%--    <asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>

</div>

</asp:Content>
