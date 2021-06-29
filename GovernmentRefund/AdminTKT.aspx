<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeFile="AdminTKT.aspx.cs" Inherits="GovernmentRefund.AdminTKT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
<div class="page-title title-t">

    <table style="width: 100%;">
        <tr>
            <td width="75%">
                &nbsp;
                <h1 style="text-align:left;"> Ticket Details </h1>
            </td>
            <td>
            </td>
        </tr>
    </table>

    <br />
</div>


<table style="width: 80%; height: 100px;">
    <tr>
        <td width="20%">
            <h3 style="text-align: left; color:#18216d; text-decoration: underline;"> Ticket Info </h3>
        </td>
    </tr>


    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Ticket #: </h6>
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> View Ticket </h6> <br />
<textarea id="TextArea1" cols="20" rows="17" style="text-align:left;"> ticket here</textarea>


        </td>
    </tr>
    <tr> <td> <br /> </td> </tr>
    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Payment Method </h6>
        </td>
    </tr>

   

   
    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Original TKT: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="OriginalTKT" name="OriginalTKT" placeholder="(optional)" type="text" />
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Tax K7: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="TaxK7" name="TaxK7" placeholder="(optional)" type="text" />
        </td>
    </tr>

    <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Sundry Charges: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="SDCharges" name="SDCharges" placeholder="(optional)" type="text" />
        </td>
    </tr>

        <tr>
        <td width="20%">
            <h6 style="text-align:left;"> Ticket Amount: </h6>
        </td>

        <td width="20%">
            <input class="input-field" id="TKTAmount" name="TKTAmount" placeholder="(optional)" type="text" />
        </td>
    </tr>



       <tr>
        <td></td>
        <td width="20%">
        <a href="AdminReqDetails.aspx" class="btn btn-primary btn-lg active" role="button">Complete</a>
        </td>
    </tr>





</table>
</asp:Content>
