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
                String txtID= "ticket" + i;
                txt.ID = txtID;
                txt.Attributes.Add("placeholder", "Enter Ticket: "+i);
                txt.CssClass = ("input-field");
                pnlTextBoxes.Controls.Add(txt);
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                rfv.ErrorMessage = "Ticket number is required!";
                rfv.ControlToValidate = txtID;
                pnlTextBoxes.Controls.Add(rfv); }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //database add
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}