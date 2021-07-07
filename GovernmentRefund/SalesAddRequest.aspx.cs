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
    public partial class SalesAddRequest : System.Web.UI.Page
    {
        int RequestNumber = new Random().Next(1000, 9999);
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Validate();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            //--------------------------------------
            int boxesNumber;
            TextBox txt = null;
            Int32.TryParse(DropDownList1.SelectedValue, out boxesNumber);
            for (int i = 1; i <= boxesNumber; i++)
            {
                txt = new TextBox();
                String txtID = "ticket" + i;
                txt.ID = txtID;
                txt.Text = null;
                txt.Attributes.Add("placeholder", "Enter Ticket: " + i);

                //------------------------------------
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                rfv.ErrorMessage = "    required field!";
                rfv.ForeColor = System.Drawing.Color.Red;
                rfv.ControlToValidate = txtID;

                //-------------------------------------
                CustomValidator cvv = new CustomValidator();
                cvv.ServerValidate += new ServerValidateEventHandler(Cv_ServerValidate);
                cvv.ErrorMessage = "   Ticket Invalid!";
                cvv.ForeColor = System.Drawing.Color.Red;
                cvv.ControlToValidate = txtID;
                cvv.Display = ValidatorDisplay.Dynamic;

                pnlTextBoxes.Controls.Add(txt);
                pnlTextBoxes.Controls.Add(rfv);
                pnlTextBoxes.Controls.Add(cvv);
            }
        }


        private void Cv_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String ticketInput = args.Value;
            Ticket ticc = new Ticket(ticketInput);
            if (ticc.TicketExists())
            {
                if (ticc.isValid() == true)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            else
            {
                args.IsValid = false;
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + ticketInput + " Doesnt exist!" + "');", true);
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            Page.Validate();
            if (Page.IsValid)
            {

                string format = "yyyy-MM-dd";
                int boxesNumber = Convert.ToInt32(DropDownList1.SelectedValue);
                TextBox t = null;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DateTime RequestDate = DateTime.Now;
                Console.WriteLine(RequestDate.ToString());
                String FilePath = "~/images/" + RequestNumber;
                int userId = 1808311;
                String action = "In Progress";


                //insert request
                cmd.CommandText = "insert into Request(RequestNumber, RequestDate, letter, CreatedBy, Action, Reason) values('" + RequestNumber + "','" + RequestDate.ToString(format) + "','" + FilePath + "','" + userId + "','" + action + "','" + " " + "')";
                cmd.ExecuteNonQuery();


                //database add
                for (int i = 1; i <= boxesNumber; i++)
                {
                    String txtID = "ticket" + i.ToString();
                    t = (TextBox)pnlTextBoxes.FindControl(txtID);
                    Ticket test = new Ticket(t.Text);
                    String TicketNumber = test.GetParsedTicket();
                    String CouponStatus = test.GetCoupon();
                    String DOIString = test.GetDOI();
                    DateTime DOI = Convert.ToDateTime(DOIString);
                    String FOP = test.GetFOP();
                    //insert ticket
                    cmd.CommandText = "insert into TicketInfo(TicketNumber, RequestNumber, CouponStatus, DOI, FOP) values('" + TicketNumber + "','" + RequestNumber + "','" + CouponStatus + "','" + DOI.ToString(format) + "','" + FOP + "')";
                    cmd.ExecuteNonQuery();
                }

                //insert flow
                cmd.CommandText = "insert into AuditTracking(RequestNumber, ModifiedBy, CreateDate, Action) values('" + RequestNumber + "','" + userId + "','" + RequestDate.ToString(format) + "','" + action + "')";
                cmd.ExecuteNonQuery();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + RequestNumber + " Was Added Succefully!" + "');", true);
                Response.Redirect("AdminDashboard.aspx");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/images/" + RequestNumber + ".png"));
                uploadStatus.Text = "Letter " + RequestNumber + " Uploaded";
                uploadStatus.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                uploadStatus.Text = "No File Selected";
                uploadStatus.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}

