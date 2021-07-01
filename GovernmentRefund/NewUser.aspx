<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="GovernmentRefund.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
    <div class="page-title">

        <h1> Add User </h1>
        <br /> 

    </div>
        <asp:TextBox class="input-fieldd" ID="Name" runat="server" placeholder="Enter Name"></asp:TextBox>
        <br>
        <asp:TextBox class="input-fieldd" ID="UserID" runat="server" placeholder="Enter User ID"></asp:TextBox>
                <br>
        <asp:TextBox class="input-fieldd" ID="Password" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
            <h6 style="text-align:center; color: white; font-size:large ;font-family:'Times New Roman', Times, serif"> Role: </h6>
        <asp:DropDownList ID="Role" runat="server">
                        <asp:ListItem>pls select</asp:ListItem>
                        <asp:ListItem Value="101">Admin</asp:ListItem>
                        <asp:ListItem Value="102">Sales</asp:ListItem>
                        <asp:ListItem Value="103">Pax</asp:ListItem>
                        <asp:ListItem Value="104">Collection</asp:ListItem>
        </asp:DropDownList>
        <br /> <br />
                <asp:Button class="my-button" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />


        </div>


</asp:Content>
