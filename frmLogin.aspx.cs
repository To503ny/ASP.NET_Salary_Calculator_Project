using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // create database variable
        dsUser dsUserLogin;
        // create string for security level
        string SecurityLevel;
        // verify login info
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        // validation loop for users information
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            //set authentication to false
            e.Authenticated = false;
            // send email
            if (clsBusinessLayer.SendEmail("to503ny@gmail.com",
            "typerdc5@live.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText +
                " Your incorrect login information was sent to receiver@receiverdomain.com";
            }
            return;
        }
        // Get security level
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // Add your comments here
        switch (SecurityLevel)
        {
            case "A":
                // Case SecurityLevel is "A" then do the following
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // Case SecurityLevel is "B" then do the following
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}