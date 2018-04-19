<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="864px" Width="828px">
            <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="150px" ImageUrl="~/images/calculator.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" Width="150px" />
            &nbsp;<asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="150px" ImageUrl="~/images/newemployee.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="150px" />
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="150px" ImageUrl="~/images/userActivity.jpg" PostBackUrl="~/frmUserActivity.aspx" Width="150px" />
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="150px" ImageUrl="~/images/viewPersonnel.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="150px" />
            &nbsp;<asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnSearch" runat="server" Height="150px" ImageUrl="~/images/search.jpg" PostBackUrl="~/frmSearchPersonnel.aspx" Width="150px" />
            &nbsp;<asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="150px" ImageUrl="~/images/editemployees.jpg" PostBackUrl="~/frmEditPersonnel.aspx" Width="150px" />
            &nbsp;<asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Employee</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="150px" ImageUrl="~/images/manageusers.jpg" PostBackUrl="~/frmManageUsers.aspx" Width="150px" />
            &nbsp;<asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
