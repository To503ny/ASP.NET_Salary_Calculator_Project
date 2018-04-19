using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnelVerrified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //when page is loaded txtVerifiedInfo will display what was entered in all the text boxes from frmPersonnel.
        txtVerifiedInfo.Text = (string)Session["txtFirstName"] + "\n" +
                               (string)Session["txtLastName"] + "\n" +
                               (string)Session["txtPayRate"] + "\n" +
                               (string)Session["txtStartDate"] + "\n" +
                               (string)Session["txtEndDate"];

        // this function is letting the users know if the new employee was saved or not.
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
        (string)Session["txtFirstName"],
        (string)Session["txtLastName"],
        (string)Session["txtPayRate"],
        (string)Session["txtStartDate"],
        (string)Session["txtEndDate"]))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was successfully saved!";
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was NOT saved.";
        }
    }
}