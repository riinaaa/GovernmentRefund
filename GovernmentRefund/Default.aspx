<%@ Page Title="Login" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GovernmentRefund._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
    <h1 class="display-4">Government Refund System</h1>

    <div class="page-title">

    </div>
        <table align="center">
            <tr>
                <td>
    <input class="input-field" id="ID" name="ID" placeholder=" Enter your ID" type="text" />
                    </td>
            </tr>
            <tr>
                <td>
    <input class="input-field" id="Password" name="Password" placeholder=" Enter your password " type="password" />
                </td>
            </tr>

        </table>
    <input class="my-button" id="Button1" type="button" value="Login" />

</div>

<div class="text-center ">
    <a href="AdminDashboard">Admin |</a>
    <a href="SalesDashboad">Sales Office | </a>
    <a href="PaxDashboard">Pax | </a>
    <a href="CollectionDashboard">Collection Team</a>
</div>

</asp:Content>
