using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmUserActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Keep users from entering a page without loging in.
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
        if (!Page.IsPostBack)
        {
            //Declares the DataSet
            dsUserActivity myDataSet = new dsUserActivity();
            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.accdb"));

            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];

            // Binds the DataGrid
            grdUserActivity.DataBind();
        }
    }
}