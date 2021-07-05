<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeBehind="AdminTKT.aspx.cs" Inherits="GovernmentRefund.AdminTKT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-title title-t">

        <table style="width: 100%;">
            <tr>
                <td style="width: 51%">&nbsp;
                <h1 style="text-align: left;">Ticket Details </h1>
                </td>
                <td></td>
            </tr>

                   <tr>
            <td style="width: 51%">
                <h3 style="text-align: left; color: #18216d; text-decoration: underline;">Ticket Info </h3>
            </td>
        </tr>


        <tr>
            <td style="width: 51%">
                <asp:Label ID="tktnumberLabel" runat="server" ></asp:Label>
            </td>
        </tr>

        </table>

        <br />
    </div>

    <table>
        <tr>
            <td class="modal-sm" style="width: 400px">
                <asp:Literal ID="fullTKT" runat="server" ></asp:Literal>

            </td>
        </tr>
    </table>


    <table style="width: 80%; height: 100px;">
 
        <tr>
            <td style="width: 6%">
                <br />
            </td>
        </tr>

        <tr>
            <td style="width: 6%">
                <h6 style="text-align: left;">Tax K7: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="TaxK7" class="input-field" runat="server" placeholder="(optional)"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 6%">
                <h6 style="text-align: left;">Sundry Charges: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="SDCharges" class="input-field" runat="server" placeholder="(optional)"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 6%">
                <h6 style="text-align: left;">Ticket Amount: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="TKTAmount" class="input-field" runat="server" placeholder="(optional)"></asp:TextBox>
            </td>
        </tr>



        <tr>
            <td style="width: 6%"></td>
            <td width="20%">
                <asp:Button ID="Button1" runat="server" Height="39px" Text="Complete" Width="123px" CssClass="my-button" OnClick="Button1_Click" />
            </td>
        </tr>





    </table>
</asp:Content>