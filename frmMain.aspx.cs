using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //on page load call SaveUserActivity
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb") , "frmPersonnel");

        // Keep users from entering a page without loging in.
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }

        // Check if administrator
        if (Session["SecurityLevel"] != "A")
        {
            imgbtnNewEmployee.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            imgbtnEditEmployees.Visible = false;
            imgbtnManageUsers.Visible = false;

            linkbtnEditEmployees.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            linkbtnNewEmployee.Visible = false;
            linkbtnManageUsers.Visible = false;
        }
        
    }
}