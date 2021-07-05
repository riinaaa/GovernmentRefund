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
            SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Users where ID=@UserID and Password=@Password", con);
            cmd.Parameters.AddWithValue("@ID", ID.Text);
            cmd.Parameters.AddWithValue("Password", Password.Text);
          ///  cmd.Parameters.AddWithValue("Role", Role);       Should I declare the role here??

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {

                //foreach (DataRow row in dt.Rows)
                //{
                //    if (row["UserName"].ToString() == this.ID.Text && row["Password"].ToString() == this.Password.Text)
                //    {
                //    if *** Htow to check the role here?? ***
                //    }
                //}

                        Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                ID.Text = "Your username and word is incorrect";
                ID.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}