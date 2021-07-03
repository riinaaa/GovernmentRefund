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

                //
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                rfv.ErrorMessage = "    required field!";
                rfv.ForeColor = System.Drawing.Color.Red;
                rfv.ControlToValidate = txtID;
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
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + ticketInput + " Doesnt exist!" + "');", true);
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int boxesNumber = Convert.ToInt32(DropDownList1.SelectedValue);
            TextBox t = null;
            for (int i = 1; i <= boxesNumber; i++)
            {
                String txtID = "ticket" + i.ToString();
                t = (TextBox)pnlTextBoxes.FindControl(txtID);
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + t.Text + "');", true);
            }



            //database add
            //if (IsPostBack)
            //{
            //    Page.Validate();
            //    if (Page.IsValid)
            //    {

            //        Response.Write("Page is valid");
            //  ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + "umm" + "');", true);
            //    }
            //}

            //    else
            //        Response.Write("Page is InValid");


        }


    }
}
