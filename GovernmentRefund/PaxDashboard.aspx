<%@ Page Title="" Language="C#" MasterPageFile="~/Paxm.Master" AutoEventWireup="true" CodeFile="PaxDashboard.aspx.cs" Inherits="GovernmentRefund.PaxDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="text-center">

        <div class="page-title title-t">

            <table style="width: 100%;">
                <tr>
                    <td width="75%">
                        &nbsp;
                        <h1 style="text-align:left;"> Requests </h1>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>

        </div>

        <table style="border-color: #CCCCCC; width: 100%; height: 100px; background-color: #eee7dd;" border="1">
            <tr>
                <td width="20%">&nbsp; Request ID </td>
                <td width="20%">&nbsp; Request Date</td>
                <td width="20%">&nbsp; By</td>
                <td width="20%">&nbsp; Status</td>
                <td width="20%">&nbsp; Compelete Request</td>

            </tr>
            <tr>
                <td class="auto-style2">&nbsp; 101 </td>
                <td width="20%">&nbsp; june 23th 2021</td>
                <td width="20%">&nbsp; Khadijah </td>
                <td width="20%">&nbsp; Processing</td>
                <td>
                  <asp:Button ID="Button1" runat="server" Height="47px" Text="Complete" Width="128px" CssClass="my-button" OnClick="Button1_Click" />
                </td>


            </tr>

        </table>



    </div>




</asp:Content>
