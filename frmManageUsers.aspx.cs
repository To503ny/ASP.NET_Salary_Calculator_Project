using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Keep users from using page unless they have logged in
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
    }

    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"), txtMngUserName.Text, txtMngPassword.Text, drpSecurityLevel.SelectedValue))
        {
            lblDisplay.Text = "The user was successfully added";
            grdManageUsers.DataBind();
        }
        else
        {
            lblDisplay.Text = "The User was not added!";
        }
    }
}