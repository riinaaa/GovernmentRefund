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
            switch (DropDownList1.SelectedValue)
            {
                case "1":
                    TextBox1.Visible = true;
                    break;
                case "2":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    break;
                case "3":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    break;
                case "4":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    break;
                case "5":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    break;
                case "6":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    break;
                case "7":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = true;
                    break;
                case "8":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = true;
                    TextBox8.Visible = true;
                    break;
                case "9":
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = true;
                    TextBox8.Visible = true;
                    TextBox9.Visible = true;
                    break;


            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //tkt parsing code so far
            String ticketNum = TextBox1.Text;
            Ticket ticc = new Ticket(ticketNum);
            String ticketFull = ticc.TktBlock();
            String ticketparsed = ticc.GetParsedTicket();
            String fop = ticc.GetFOP();
            String DOI = ticc.GetDOI();
            String couponStatus = ticc.GetCoupon();
            Boolean valid = false;
            if (valid==true)
            {

            }

            else
            {

            }


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}