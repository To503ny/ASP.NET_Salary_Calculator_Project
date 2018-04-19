<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">HyperLink</asp:HyperLink>
        <br />
    
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtAnnualHours" runat="server" width="149px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblRate" runat="server" Text="Rate:" width="86px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPayRate" runat="server" width="144px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCalculateSalary" runat="server" OnClick="Button1_Click" Text="Calculate Salary" />
        <br />
        <br />
        <asp:Label ID="lblAnnualSalary" runat="server" Text="$"></asp:Label>
    
    </div>
    </form>
</body>
</html>
