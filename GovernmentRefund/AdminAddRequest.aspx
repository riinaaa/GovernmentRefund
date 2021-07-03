<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeBehind="AdminAddRequest.aspx.cs" Inherits="GovernmentRefund.AdminAddRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h1 class="display-4">New Request</h1>
        <br />
        <br />
        <h3 style="text-align: left; color: #18216d; text-decoration: underline;">Request Info: </h3>
        <br />
        <table style="width: 53%; height: 255px;">
            <tr>
                <td width="20%">
                    <h4 style="text-align: left;">Upload Letter: </h4>
                    &nbsp;</td>
                <td width="20%">
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="23px" Width="201px" />
<asp:Button CssClass="my-button" ID="uploadbtn" runat="server" Text="Upload" Height="33px" Width="89px" OnClick="Button2_Click" />
                                         <asp:Label ID="uploadStatus" runat="server" style="text-align: center;"></asp:Label>
                </td>

            </tr>
            <tr>
                <td width="20%">
                    <h4 style="text-align: left;">Number Of Tickets: </h4>
                    &nbsp;</td>
                <td width="20%">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                        <asp:ListItem Value="" Text="Please Select" />
                        <asp:ListItem Value="1" Text="1" />
                        <asp:ListItem Value="2" Text="2" />
                        <asp:ListItem Value="3" Text="3" />
                        <asp:ListItem Value="4" Text="4" />
                        <asp:ListItem Value="5" Text="5" />
                        <asp:ListItem Value="6" Text="6" />
                        <asp:ListItem Value="7" Text="7" />
                        <asp:ListItem Value="8" Text="8" />
                        <asp:ListItem Value="9" Text="9" />
                    </asp:DropDownList>

                    &nbsp;</td>
            </tr>

            <tr>
                <td>
                    <h4 style="text-align: left;">Enter Tickets: </h4>
                    &nbsp;

                </td>
                <td width="40%">

                    <asp:Panel ID="pnlTextBoxes" runat="server">
                    </asp:Panel>
                    &nbsp;


                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="47px" Text="Add Request" Width="128px" CssClass="my-button" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
