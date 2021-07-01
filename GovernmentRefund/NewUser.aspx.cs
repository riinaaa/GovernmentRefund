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
    public partial class NewUser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
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
            int Roleval = Int32.Parse(Role.SelectedValue);
            cmd.CommandText="insert into Users values('"+ UserID.Text+ "','"+ Name.Text + "','"+ Password.Text + "','"+ Roleval + "')";
            cmd.ExecuteNonQuery();
        }
    }
}