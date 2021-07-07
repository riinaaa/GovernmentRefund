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
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str, UserID, Passwordd,name;
            SqlCommand com;
            SqlDataAdapter sqlda;
            DataTable dt;
            int RowCount;
            int Role = 0;

            // str = "Select * from Users WHERE UserID=' " + ID.Text.Trim() + " ' , Password = ' " + Password.Text.Trim() + " ' ";
            con.Open();
            str = "Select * from Users";
            com = new SqlCommand(str);
            sqlda = new SqlDataAdapter(com.CommandText, con);
            dt = new DataTable();
            sqlda.Fill(dt);
            RowCount = dt.Rows.Count;

            for (int i = 0; i < RowCount; i++)
            {
                name = dt.Rows[i]["name"].ToString();
                UserID = dt.Rows[i]["UserID"].ToString();
                Passwordd = dt.Rows[i]["Password"].ToString();
                if (UserID == ID.Text && Passwordd == Password.Text)
                {
                    Session["userID"] = UserID;
                    Session["name"] = name;

                    if (dt.Rows[i]["RoleId"].ToString() == "101")
                    {
                        Response.Redirect("~/AdminDashboard.aspx");
                    }
                    else if (dt.Rows[i]["RoleId"].ToString() == "102")
                    {
                        Response.Redirect("~/SalesDashboad.aspx");
                    }
                    else if (dt.Rows[i]["RoleId"].ToString() == "103")
                    {
                        Response.Redirect("~/PaxDashboard.aspx");
                    }
                    else if (dt.Rows[i]["RoleId"].ToString() == "104")
                    {
                        Response.Redirect("~/CollectionDashboard.aspx");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + " Inalid Id Or Password!" + "');", true);
                }
            }
        }
    }
}







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
