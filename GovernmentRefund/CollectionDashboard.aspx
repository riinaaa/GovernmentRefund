<%@ Page Title="" Language="C#" MasterPageFile="~/Collectionm.Master" AutoEventWireup="true" CodeBehind="CollectionDashboard.aspx.cs" Inherits="GovernmentRefund.CollectionDashboard" %>
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

        <asp:GridView ID="GridView1" class="table table-bordered table-condensed table-responsive table-hover" HeaderStyle-BackColor="#eee7dd" runat="server" BorderColor="White" ForeColor="Black">
        </asp:GridView>


    <h4>Total Requests: </h4>
    <asp:Button ID="Button2" runat="server" Height="47px" Text="Generate Report" Width="151px" CssClass="my-button" OnClick="Button2_Click" />



</div>
</asp:Content>
