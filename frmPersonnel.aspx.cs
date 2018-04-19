using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Keep users from entering a page without loging in.
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
        // Check if administrator
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
            //If admin set to true
        }
        else
        {
            btnSubmit.Visible = false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //create variables
        string sessionFirstName = txtFirstName.Text;
        string sessionLastName = txtLastName.Text;
        string sessionPayRate = txtPayRate.Text;
        string sessionStartDate = txtStartDate.Text.ToString();
        string sessionEndDate = txtEndDate.Text.ToString();
        string errorMsg = "Error: " + "\n\n";
        bool validatedState = false;

        // Validate fields are not empty
        if (Request["txtFirstName"].ToString().Trim() =="")
        {
            validatedState = false;
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "First Name cannot be empty!" + "\n\n";
        }
        else
        {
            txtFirstName.BackColor = System.Drawing.Color.White;
        }

        if(Request["txtLastName"].ToString().Trim() == "")
        {
            validatedState = false;
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "Last Name cannot be empty!" + "\n\n";
        }
        else
        {
            txtLastName.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtPayRate"].ToString().Trim() =="")
        {
            validatedState = false;
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "Pay Rate cannot be empty!" + "\n\n";
        }
        else
        {
            txtPayRate.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtStartDate"].ToString().Trim() == "")
        {
            validatedState = false;
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "Start Date cannot be empty!" + "\n\n";
        }
        else
        {
            txtStartDate.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtEndDate"].ToString().Trim() == "")
        {
            validatedState = false;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "End Date cannot be empty!" + "\n\n";
        }
        else
        {
            txtEndDate.BackColor = System.Drawing.Color.White;
        }

        //validate txtStartDate and txtEndDate
        DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
        DateTime endDate = DateTime.Parse(Request["txtEndDate"]);

        if (DateTime.Compare(startDate, endDate) > 0)
        {
            validatedState = false;
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            errorMsg += "The end date must be a later date than the start date." + "\n\n";
        }
        else
        {
            txtStartDate.BackColor = System.Drawing.Color.White;
            txtEndDate.BackColor = System.Drawing.Color.White;
        }

        //test to make sure all feilds are valid
        if (Request["txtFirstName"].ToString().Trim() != "" && 
            Request["txtLastName"].ToString().Trim() != "" && 
            Request["txtPayRate"].ToString().Trim() != "" &&
            Request["txtPayRate"].ToString().Trim() != "" &&
            Request["txtEndDate"].ToString().Trim() != "")
        {
            validatedState = true;
        }

            if (validatedState == true)
        {
            //set up session states
            Session["txtFirstName"] = sessionFirstName;
            Session["txtLastName"] = sessionLastName;
            Session["txtPayRate"] = sessionPayRate;
            Session["txtStartDate"] = sessionStartDate;
            Session["txtEndDate"] = sessionEndDate;

            Response.Redirect("frmPersonnelVerrified.aspx");
        }
        else
        {
            lblError.Text = errorMsg;
        }

    }//end btnSubmit_Click()

    protected void btnViewPersonnel_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmViewPersonnel.aspx");
    }
}