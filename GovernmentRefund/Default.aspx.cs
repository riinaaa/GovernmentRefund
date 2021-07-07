using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Configuration;


namespace GovernmentRefund
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            //int Role=0;
            //SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from Users where UserID=@ID.Text and Password=@Password.Text", con);
            //cmd.Parameters.AddWithValue("@UserID", ID.Text);
            //cmd.Parameters.AddWithValue("Password", Password.Text);
            //cmd.Parameters.AddWithValue("RoleId", Role); 

            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();

            //if (dt.Rows.Count > 0)
            //{

            //    foreach (DataRow row in dt.Rows)
            //    {
            //        if (row["UserName"].ToString() == this.ID.Text && row["Password"].ToString() == this.Password.Text)
            //        {
            //            if (Role == 101)
            //            {
            //                Response.Redirect("AdminDashboard.aspx");
            //            }

            //            else if (Role == 102)
            //            {
            //                Response.Redirect("SalesDashboard.aspx");
            //            }

            //            else if (Role == 103)
            //            {
            //                Response.Redirect("PaxDashboard.aspx");
            //            }

            //            else if (Role == 104)
            //            {
            //                Response.Redirect("CollectionDashboard.aspx");
            //            }

            //        }
            //    }

            //}
            //else
            //{
            //    ID.Text = "Your username and word is incorrect";
            //    ID.ForeColor = System.Drawing.Color.Red;

            //}
        }
    }
}