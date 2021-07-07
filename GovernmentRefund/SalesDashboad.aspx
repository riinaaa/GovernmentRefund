<%@ Page Title="" Language="C#" MasterPageFile="~/Salesm.Master" AutoEventWireup="true" CodeBehind="SalesDashboad.aspx.cs" Inherits="GovernmentRefund.SalesDashboad" %>
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

       <asp:GridView ID="GridView1" class="table table-bordered table-condensed table-responsive table-hover" HeaderStyle-BackColor="#eee7dd" runat="server" BorderColor="White" ForeColor="Black">
<%--        <asp:HyperLinkField Text="View/Edit" DataNavigateUrlFields="RequestNumber" DataNavigateUrlFormatString="AdminReqDetails.aspx?RequestNumber={0}"/>--%>
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="RequestNumber" DataNavigateUrlFormatString="AdminReqDetails.aspx?RequestNumber={0}" HeaderText="Complete Request" Text="Complete" />
        </Columns>
<HeaderStyle BackColor="#EEE7DD"></HeaderStyle>
    </asp:GridView>
    </div>
</asp:Content>
