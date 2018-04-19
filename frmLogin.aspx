﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

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
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/frmMain.aspx" TitleText="Please enter your UserName and Password in order to log into the system" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
        <br />
    
    </div>
    </form>
</body>
</html>
