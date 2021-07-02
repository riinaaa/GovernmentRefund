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
    public partial class AdminAddRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int boxesNumber = Convert.ToInt32(DropDownList1.SelectedValue);

            for (int i = 1; i <= boxesNumber; i++)
            {
                TextBox txt = new TextBox();
                txt.ID = "ticket" + i;
                txt.Attributes.Add("placeholder", "Enter Ticket: "+i);
                pnlTextBoxes.Controls.Add(txt);
                txt.CssClass = ("input-field");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }

        //protected void TextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //tkt parsing code so far
        //    String ticketNum = TextBox1.Text;
        //    Ticket ticc = new Ticket(ticketNum);
        //    String ticketFull = ticc.TktBlock();
        //    String ticketparsed = ticc.GetParsedTicket();
        //    String fop = ticc.GetFOP();
        //    String DOI = ticc.GetDOI();
        //    String couponStatus = ticc.GetCoupon();
        //    Boolean valid = false;
        //    if (valid==true)
        //    {

        //    }

        //    else
        //    {

        //    }


        //}

        //protected void TextBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox3_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox4_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox5_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox6_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox7_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox8_TextChanged(object sender, EventArgs e)
        //{

        //}

        //protected void TextBox9_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}