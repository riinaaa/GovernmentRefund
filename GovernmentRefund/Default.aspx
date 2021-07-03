<%@ Page Title="Login" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GovernmentRefund._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
    <h1 class="display-4">Government Refund System</h1>

    <div class="page-title">

    </div>
        <table align="center">
            <tr>
                <td>
                    <asp:TextBox ID="ID" class="input-field" placeholder=" Enter your ID" runat="server"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>
                <asp:TextBox ID="Password" class="input-field" placeholder=" Enter your password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>

        </table>
        <asp:Button ID="Button1" class="my-button" runat="server" Text="Login" />

</div>

<div class="text-center ">
    <a href="AdminDashboard">Admin |</a>
    <a href="SalesDashboad">Sales Office | </a>
    <a href="PaxDashboard">Pax | </a>
    <a href="CollectionDashboard">Collection Team</a>
</div>

</asp:Content>
