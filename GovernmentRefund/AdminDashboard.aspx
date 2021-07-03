<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="AdminDashboard.aspx.cs" Inherits="GovernmentRefund.AdminDashboard" %>
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
                <td width="20%">&nbsp;<b> Request ID </b> </td>
                <td width="20%">&nbsp; <b>Request Date </b></td>
                <td width="20%">&nbsp; <b> By </b></td>
                <td width="20%">&nbsp; <b> Status </b></td>
                <td width="20%">&nbsp;<b> Compelete Request</b></td>

            </tr>
            <tr>
                <td id="RequestID" class="auto-style2">&nbsp; 101 </td>
                <td id="RequestDate" width="20%">&nbsp; june 23th 2021</td>
                <td id="CreatedBy" width="20%">&nbsp; Khadijah </td>
                <td id="Action" width="20%">&nbsp; Processing</td>

                <td>
                  <asp:Button ID="EditButton" runat="server" Height="47px" Text="Complete" Width="128px" CssClass="my-button" OnClick="Button1_Click" />
                </td>


            </tr>

        </table>



    </div>
</asp:Content>
