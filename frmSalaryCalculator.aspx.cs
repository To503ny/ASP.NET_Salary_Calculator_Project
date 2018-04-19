using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //declare variables
        double annualHours = Convert.ToDouble(txtAnnualHours.Text);
        double payRate = Convert.ToDouble(txtPayRate.Text);
        double annualSalary = annualHours * payRate;

        //chang lblAnnualSalary to show calcualtion of annualSalary
        lblAnnualSalary.Text = "Your Annual Salary is: $" + Convert.ToString(annualSalary);
        
    }
}