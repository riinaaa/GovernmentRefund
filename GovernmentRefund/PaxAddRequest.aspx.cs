using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GovernmentRefund
{
    public partial class PaxAddRequest : System.Web.UI.Page
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
                String txtID = "ticket" + i;
                txt.ID = txtID;
                txt.Attributes.Add("placeholder", "Enter Ticket: " + i);
                txt.CssClass = ("inputttt-tickets");
                //
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                rfv.ErrorMessage = "    required field!";
                rfv.ForeColor = System.Drawing.Color.Red;
                rfv.ControlToValidate = txtID;
                //
                CustomValidator cvv = new CustomValidator();
                cvv.ID = "cvvc" + i;
                cvv.ServerValidate += new ServerValidateEventHandler(Cv_ServerValidate);
                cvv.ErrorMessage = "   Ticket Invalid!";
                cvv.ForeColor = System.Drawing.Color.Red;
                cvv.ControlToValidate = txtID;
                cvv.Display = ValidatorDisplay.Dynamic;
                //
                pnlTextBoxes.Controls.Add(txt);
                pnlTextBoxes.Controls.Add(rfv);
                pnlTextBoxes.Controls.Add(cvv);

                // if all the tickets werent valid the label at the end will say so and if not the label will be red with invalid written
            }
        }

        private void Cv_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String ticketInput = args.Value;
            Response.Write(ticketInput);

            Ticket ticc = new Ticket(ticketInput);
            if (ticc.isValid() == true)
            {
                Response.Write(ticketInput);
                args.IsValid = true;
                labelStatus.Text = "tiii";
            }
            else
            {
                args.IsValid = false;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //database add
            if (IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    Response.Write("Page is valid");
                    //back to dashboard
                }
                else
                    Response.Write("Page is InValid");


            }
        }
    }
}
