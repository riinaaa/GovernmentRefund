<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeBehind="AdminReqDetails.aspx.cs" Inherits="GovernmentRefund.AdminReqDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="page-title title-t">

    <table style="width: 100%;">
        <tr>
            <td width="75%">
                &nbsp;
                <h1 style="text-align:left;"> Request Details </h1>
                <asp:Label ID="requestIDD" runat="server"></asp:Label>
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
            <asp:TextBox ID="AccountNumber" class="input-field" runat="server"  placeholder="IBAN"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;">Reference #: </h6>
        </td>

        <td width="20%">
            <asp:TextBox ID="ReferenceNumber" class="input-field" runat="server"  placeholder="Reference #"></asp:TextBox>
        </td>
    </tr>


    <tr>
        <td width="20%">
            <h6 style="text-align:left;">Total Fare: </h6>
        </td>

        <td width="20%">
                 <asp:TextBox ID="TotalFare" class="input-field" runat="server"  placeholder="Total Fare for all tickets.."></asp:TextBox>
        </td>
    </tr>

        <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Approval: </h6>
        </td>

        <td width="60%">
            <fieldset>
            <asp:RadioButton ID="approvebtn" value="TRUE" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Aprove"></asp:Label>
            <asp:RadioButton ID="rejectbtn" runat="server" value="FALSE" />
            <asp:Label ID="Label2" runat="server" Text="Reject"></asp:Label>
            </fieldset>
            Reason:
            <asp:TextBox ID="Reason" class="input-field" runat="server" visibel=""></asp:TextBox>

            <%--         <input type="radio" id="reject" name="Request_Approval" value="FALSE" onclick="ShowHideDiv()">--%>

<%--            <script type="text/javascript">function ShowHideDiv() {
                    var reject = document.getElementById("reject");
                    var dvReject = document.getElementById("dvReject");
                    dvReject.style.display = reject.checked ? "block" : "none";
                }</script>

            <div id="dvReject" style="display: none">
                Reason:
                <input type="text" id="txtReason" />
            </div>--%>
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
            <asp:Button ID="Button1" runat="server" Text="Update" CssClass="my-button" OnClick="Button1_Click" />
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
<textarea id="TextTKT" name="TextTKT" cols="20" rows="17"> Ticket Here </textarea>
            
        </td>
        <td>
          <asp:Button ID="Button2" runat="server" Text="Edit" CssClass="my-button" OnClick="Button2_Click" />
        </td>
    </tr>
</table>

    <asp:Button ID="Button3" runat="server" Text="View Letter" CssClass="my-button" OnClick="Button3_Click" />


</asp:Content>

