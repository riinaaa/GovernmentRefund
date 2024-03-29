﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GovernmentRefund
{
    public partial class SalesDashboad : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["userID"]);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            displayData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminReqDetails.aspx");
        }

        protected void displayData()
        {
            int userID = Convert.ToInt32(Session["userID"]);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select RequestNumber, RequestDate, CreatedBy, Action from Request where createdBy= " + userID;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}