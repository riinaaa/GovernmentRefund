<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="AdminReport.aspx.cs" Inherits="GovernmentRefund.AdminReport" %>
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

            <label for="FromDate">From:</label>
            <input style="color:black" type="date" id="FromDate" name="FromDate">
            <label for="ToDate">To:</label>
            <input style="color:black" type="date" id="ToDate" name="ToDate">
        <a href="AdminReport.aspx" class="btn btn-primary btn-lg active" role="button">Search</a>

        <br />

        <select style="color:black" name="ReqStatus" id="dropdown" required>
            <option value="All">All</option>
            <option value="Approved">Approved</option>
            <option value="Rejected">Rejected</option>
            <option value="InProgress">In Progress</option>
        </select>

    </div>   <br />

    <table style="border-color: #CCCCCC; width: 100%; height: 100px; background-color: #eee7dd;" border="1">
        <tr>
            <td>&nbsp; Request ID </td>
            <td>&nbsp; Request Date</td>
            <td>&nbsp; By</td>
            <td>&nbsp; Total Amount</td>
            <td>&nbsp; Tax K7 </td>
            <td>&nbsp; Sundry Charges </td>
            <td>&nbsp; Refernce Number</td>
            <td>&nbsp; Account Number</td>
            <td>&nbsp; Status</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp; 101 </td>
            <td>&nbsp; june 23th 2021</td>
            <td>&nbsp; Rina </td>
            <td>&nbsp; 2000.00</td>
            <td>&nbsp; 300.00 </td>
            <td>&nbsp; 0.00 </td>
            <td>&nbsp; 2928383 </td>
            <td>&nbsp; 102938474939</td>
            <td>&nbsp; Processing</td>
        </tr>
    </table>
    <h4>Total Requests: </h4>
    <input class="my-button" id="Button5" type="button" value="Generate Report" />



</div>
</asp:Content>
