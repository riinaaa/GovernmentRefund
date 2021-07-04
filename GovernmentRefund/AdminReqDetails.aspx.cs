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
    public partial class AdminReqDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Style["display"] = "none";

            Image1.ImageUrl="";
            String RequestNumberString = Request.QueryString["RequestNumber"];
            requestIDD.Text = "Request Number: " + RequestNumberString;
            TextBox txt = null;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            displayData();
            //int RequestNumber = Convert.ToInt32(RequestNumberString);
            //String path = "";
            //SqlCommand sql = new SqlCommand("SELECT letter FROM Request where RequestNumber=" + RequestNumber, con);
            //path = (String)sql.ExecuteScalar();
            //Console.WriteLine(path);
            //Image1.ImageUrl = path;
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
            String RequestNumberString = Request.QueryString["RequestNumber"];
            int RequestNumber = Convert.ToInt32(RequestNumberString);
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
            cmd.CommandText = "update Request set RefernceNumber='"+ ReferenceNumber.Text + "' , AccountNumber='"+ AccountNumber.Text + "', TotalFare='" + totalFare + "', Action='" + Action + "', Reason='" + reasondb + "' where RequestNumber=" + RequestNumber + "";
            cmd.ExecuteNonQuery();

            //insert flow
            cmd.CommandText = "insert into AuditTracking(RequestNumber, ModifiedBy, CreateDate, Action, Reason) values('" + RequestNumber + "','" + userId + "','" + RequestDate.ToString(format) + "','" + Action + "','" + reasondb + "')";
            cmd.ExecuteNonQuery();

            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + RequestNumber + " Updated!" + "');", true);




        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String RequestNumberString = Request.QueryString["RequestNumber"];
            String path = "~/images/" + RequestNumberString;
            Console.WriteLine("~/images/" + RequestNumberString);
            Image1.ImageUrl = path;
        }

        protected void displayData()
        {
            String RequestNumberString = Request.QueryString["RequestNumber"];
            int RequestNumber = Convert.ToInt32(RequestNumberString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TicketInfo where RequestNumber="+ RequestNumber;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}