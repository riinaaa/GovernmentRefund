using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GovernmentRefund
{
    public partial class AdminReport : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            displayData();
            displayData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminReport.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void displayData()
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select r.RequestNumber, r.RequestDate, r.CreatedBy, r.TotalFare, r.RefernceNumber, r.AccountNumber, a.Action from Request r INNER JOIN AuditTracking a ON r.RequestNumber = a.RequestNumber";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


    }
}