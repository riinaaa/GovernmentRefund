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
        SqlConnection con = new SqlConnection(@"Data Source=RINA-RAZER\SQLEXPRESS;Initial Catalog=GR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
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
            //Ticket test = new Ticket("0652124750775");
            //Response.Write(test.GetCoupon());
            //Response.Write(test.GetDOI());
            //Response.Write(test.GetFOP());
            //Response.Write(test.isValid());



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
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + ticketInput + " Doesnt exist!" + "');", true);
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int requestNumber = new Random().Next(1000, 9999);

            int boxesNumber = Convert.ToInt32(DropDownList1.SelectedValue);
            TextBox t = null;

            //database add
            for (int i = 1; i <= boxesNumber; i++)
            {
                String txtID = "ticket" + i.ToString();
                t = (TextBox)pnlTextBoxes.FindControl(txtID);
            }


        }


    }
}