<%@ Page Title="" Language="C#" MasterPageFile="~/Collectionm.Master" AutoEventWireup="true" CodeFile="CollectionDashboard.aspx.cs" Inherits="GovernmentRefund.CollectionDashboard" %>
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

            <%--<label for="FromDate">From:</label>
            <input style="color:black" type="date" id="FromDate" name="FromDate">
            <label for="ToDate">To:</label>
            <input style="color:black" type="date" id="ToDate" name="ToDate">--%>

            <asp:Label ID="Label1" runat="server" Text="From:"></asp:Label>
         <asp:TextBox ID="TxtDob" runat="server" TextMode="Date" style="color:black"> </asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="To:"></asp:Label>
         <asp:TextBox ID="TxtDob2" runat="server" TextMode="Date" style="color:black"> </asp:TextBox>

         <asp:Button ID="Button1" runat="server" Height="39px" Text="Search" Width="123px" CssClass="my-button" OnClick="Button1_Click" />

        <br />

        <asp:DropDownList id="DropDownList1" runat="server" style="color:black" AutoPostBack="true">
               <asp:ListItem Value="All" Text="All" /> 
               <asp:ListItem Value="Approved" Text="Approved" />
               <asp:ListItem Value="Rejected" Text="Rejected" />
               <asp:ListItem Value="In Progress" Text="In Progress" />
                </asp:DropDownList>
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
    <asp:Button ID="Button2" runat="server" Height="47px" Text="Generate Report" Width="151px" CssClass="my-button" OnClick="Button2_Click" />




</div>

</asp:Content>
