<%@ Page Title="" Language="C#" MasterPageFile="~/Adminm.Master" AutoEventWireup="true" CodeBehind="AdminReqDetails.aspx.cs" Inherits="GovernmentRefund.AdminReqDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-title title-t">

        <table style="width: 100%;">
            <tr>
                <td width="75%">&nbsp;
                <h1 style="text-align: left;">Request Details </h1>
                    <asp:Label ID="requestIDD" runat="server"></asp:Label>
                </td>
                <td></td>
            </tr>
        </table>


    </div>


    <table style="width: 80%; height: 100px;">

        <tr>
            <td width="20%">
                <h3 style="text-align: left; color: #18216d; text-decoration: underline;">Request Info </h3>
            </td>
        </tr>

        <tr>
            <td width="20%">
                <h6 style="text-align: left;">Account #: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="AccountNumber" class="input-field" runat="server" placeholder="IBAN"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td width="20%">
                <h6 style="text-align: left;">Reference #: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="ReferenceNumber" class="input-field" runat="server" placeholder="Reference #"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td width="20%">
                <h6 style="text-align: left;">Total Fare: </h6>
            </td>

            <td width="20%">
                <asp:TextBox ID="TotalFare" class="input-field" runat="server" placeholder="Total Fare for all tickets.."></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td width="20%">
                <h6 style="text-align: left;">Approval: </h6>
            </td>

            <td width="60%">
                <fieldset>
                    <asp:RadioButton ID="approvebtn" value="TRUE" runat="server" AutoPostBack="True" GroupName="approval" OnCheckedChanged="approvebtn_CheckedChanged" />
                    <asp:Label ID="Label1" runat="server" Text="Aprove"></asp:Label>
                    <asp:RadioButton ID="rejectbtn" runat="server" value="FALSE" OnCheckedChanged="rejectbtn_CheckedChanged" AutoPostBack="True" GroupName="approval" />
                    <asp:Label ID="Label2" runat="server" Text="Reject"></asp:Label>
                </fieldset>

                <asp:Label ID="reasonlabel" runat="server" Text="Reason:" Visible="false"></asp:Label>
                <asp:TextBox ID="Reasontxt" class="input-field" runat="server" Visible="false"></asp:TextBox>

            </td>

        </tr>

        <tr>
            <td>&nbsp;
            </td>
        </tr>



        <tr>
            <td></td>
            <td width="20%">
                <asp:Button ID="requestUpdatebtn" runat="server" Text="Update" CssClass="my-button" OnClick="Button1_Click" />
            </td>
        </tr>

        <tr>
            <td>
                <h1>&nbsp;
                
    <asp:Button ID="Button3" runat="server" Text="View Letter" CssClass="my-button" OnClick="Button3_Click" />
                    <asp:Image ID="Image1" runat="server" Height="188px" style="margin-bottom: 94px" Width="379px" />
                    <script>
                        Button1.OnClientClick ="document.getElementById('" + Image1.ClientID + "').style.display = 'block'";
                    </script>
                </h1>
            </td>
        </tr>
    </table>
    <hr />



    <h3 align="center" style="color: #18216d; text-decoration: underline;">Tickets: </h3>

    <asp:GridView ID="GridView1" runat="server" class="table table-bordered table-condensed table-responsive table-hover" HeaderStyle-BackColor="#eee7dd" BorderColor="White" ForeColor="Black">
                <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="TicketNumber" DataNavigateUrlFormatString="AdminTKT.aspx?TicketNumber={0}" HeaderText="Complete Ticket" Text="Edit" />
        </Columns>
    </asp:GridView>


</asp:Content>

