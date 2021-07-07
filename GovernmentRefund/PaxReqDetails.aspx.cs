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
    public partial class PaxReqDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            String RequestNumber = Request.QueryString["RequestNumber"];
            String RequestNumberr = Request.QueryString["RequestNumberr"];
            String letterPath = "~/images/" + RequestNumber + ".PNG";
            labelReq.Text = "Request Number: " + RequestNumber;
            Image1.ImageUrl = letterPath;
            Image1.Visible = false;
            requestIDD.Text = RequestNumber;
            requestIDD.Visible = false;
            TextBox txt = null;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            int RequestNumberInt;
            Int32.TryParse(RequestNumber, out RequestNumberInt);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TicketInfo where RequestNumber=" + RequestNumberInt;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void rejectbtn_CheckedChanged(object sender, EventArgs e)
        {
            Reasontxt.Visible = true;
            reasonlabel.Visible = true;
        }

        protected void approvebtn_CheckedChanged(object sender, EventArgs e)
        {
            Reasontxt.Visible = false;
            reasonlabel.Visible = false;
        }

        //request update btn
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String RequestNumberString = requestIDD.Text;
            int RequestNumberDF = Convert.ToInt32(RequestNumberString);
            double totalFare = Convert.ToDouble(TotalFare.Text);
            String Action = "";
            DateTime RequestDate = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            String reasondb = Reasontxt.Text + " ";

            int userId = 1808311;

            if (approvebtn.Checked)
            {
                Action = "Approved";
            }
            else if (rejectbtn.Checked)
            {
                Action = "Rejected";
            }

            //update 
            cmd.CommandText = "update Request set RefernceNumber='" + ReferenceNumber.Text + "' , AccountNumber='" + AccountNumber.Text + "', TotalFare='" + totalFare + "', Action='" + Action + "', Reason='" + reasondb + "' where RequestNumber=" + RequestNumberDF + "";
            cmd.ExecuteNonQuery();

            //insert flow
            cmd.CommandText = "insert into AuditTracking(RequestNumber, ModifiedBy, CreateDate, Action, Reason) values('" + RequestNumberDF + "','" + userId + "','" + RequestDate.ToString(format) + "','" + Action + "','" + reasondb + "')";
            cmd.ExecuteNonQuery();

            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + RequestNumberDF + " Updated!" + "');", true);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Image1.Visible = true;
        }
    }
}