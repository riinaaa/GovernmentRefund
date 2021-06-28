<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="AdminReqDetails.aspx.cs" Inherits="GovernmentRefund.AdminReqDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="page-title title-t">

    <table style="width: 100%;">
        <tr>
            <td width="75%">
                &nbsp;
                <h1 style="text-align:left;"> Request Details </h1>
            </td>
            <td>
            </td>
        </tr>
    </table>

    <br />

</div>
<br />


<table style="width: 80%; height: 100px;">

    <tr>
        <td width="20%">
            <h3 style="text-align: left; color:#18216d; text-decoration: underline;"> Request Info </h3>
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;">Account #: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="Text3" placeholder="IBAN" type="text" />
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;">Reference #: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="Text2" placeholder="Reference #" type="text" />
        </td>
    </tr>


    <tr>
        <td width="20%">
            <h6 style="text-align:left;">Total Fare: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="Text4" placeholder="Total Fare for all tickets.." type="text" />
        </td>
    </tr>

        <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Approval: </h6>
        </td>

        <td width="60%">
            <input type="radio" id="approve" name="Request_Approval" value="TRUE" onclick="ShowHideDiv()">
            <label for="approve">Approve</label><br>
            <input type="radio" id="reject" name="Request_Approval" value="FALSE" onclick="ShowHideDiv()">
            <label for="reject">Reject</label><br>

            <script type="text/javascript">function ShowHideDiv() {
                    var reject = document.getElementById("reject");
                    var dvReject = document.getElementById("dvReject");
                    dvReject.style.display = reject.checked ? "block" : "none";
                }</script>

            <div id="dvReject" style="display: none">
                Reason:
                <input type="text" id="txtReason" />
            </div>
        </td>
    </tr>

    <tr>
        <td>
                &nbsp;
        </td>

                <td>
                &nbsp;
        </td>
    </tr>

    <tr>
        <td></td>
        <td width="20%">
        <a href="AdminReqDetails.aspx" class="btn btn-primary btn-lg active" role="button">Update</a>
        </td>
    </tr>

    <tr>
        <td>
            <h1>
                &nbsp;
            </h1>
        </td>
    </tr>
</table>
<hr />



<h3 align="center" style=" color:#18216d; text-decoration: underline;">Tickets: </h3>
<table align="right">

    <tr>
        <td>
<textarea id="TextArea1" cols="20" rows="17"> Ticket Here </textarea>
        </td>
        <td>
          <a href="AdminTKT.aspx" class="btn btn-primary btn-lg active" role="button">Edit</a>
        </td>
    </tr>
</table>


<input align="left" class="my-button" id="Button3" type="button" value="View Letter" />

</asp:Content>

