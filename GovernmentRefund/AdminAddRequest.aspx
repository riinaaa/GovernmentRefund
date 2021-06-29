<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="AdminAddRequest.aspx.cs" Inherits="GovernmentRefund.AdminAddRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="text-center">
    <h1 class="display-4">New Request</h1>

<table style="width: 60%; height: 100px;">
    <tr>
        <td width="20%">
            <h3 style="text-align: left; color:#18216d; text-decoration: underline;"> Request Info </h3>
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Upload Letter: </h6>
        </td>

        <td width="20%">
            <input type="file" id="myFile" name="filename">
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Number Of Tickets: </h6>
        </td>

        <td width="20%">
            <select name="numDep" id="dropdown">
                <option value="">Please Select</option>
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">4</option>
                <option value="5">5</option>
                <option value="5">5</option>
                <option value="6">6</option>
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
            </select>
        </td>
    </tr>

    <tr>
        <td>
            <h6 style="text-align:left;"> Enter Tickets: </h6>
        </td>
        <td id="textboxDiv"></td>
    </tr>

    <tr>
        <td></td>
        <td width="20%">
        </td>
    </tr>
</table>

        <a href="AdminDashboard.aspx" class="btn btn-primary btn-lg active" role="button">Add Request</a>


</div>
    
</asp:Content>
