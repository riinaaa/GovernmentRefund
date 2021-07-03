using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GovernmentRefund
{
    public partial class AdminReqDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String RequestNumber = Request.QueryString["RequestNumber"];
            requestIDD.Text = "Request Number: " + RequestNumber;
            TextBox txt = null;

            if (rejectbtn.Checked == true)
            {
                Reason.Enabled=(true);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminTKT.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
        }
    }
}