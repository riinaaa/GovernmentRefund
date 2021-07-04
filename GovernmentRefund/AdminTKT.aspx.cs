using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GovernmentRefund
{
    public partial class AdminTKT : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            String TicketNumber = Request.QueryString["TicketNumber"];
            tktnumberLabel.Text = "Ticket #: " + TicketNumber +" .";
            Ticket test = new Ticket(TicketNumber);
            fullTKT.Text = test.TktBlock();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String TicketNumber = Request.QueryString["TicketNumber"];
            double amount = Convert.ToDouble(TKTAmount.Text);
            double tax = Convert.ToDouble(TaxK7.Text);
            double sundry = Convert.ToDouble(SDCharges.Text);


            //update 
            cmd.CommandText = "update TicketInfo set SundryCharges='" + sundry + "' , tax='" + tax + "', amount='" + amount + "' where TicketNumber=" + TicketNumber + "";
            cmd.ExecuteNonQuery();

            Response.Redirect("AdminReqDetails.aspx");

        }
    }
}