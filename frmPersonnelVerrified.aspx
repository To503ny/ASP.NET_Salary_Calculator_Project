<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerrified.aspx.cs" Inherits="frmPersonnelVerrified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">HyperLink</asp:HyperLink>
        &nbsp;<asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" Width="650px">
            <asp:Label ID="Label1" runat="server" Text="Information to submit"></asp:Label>
            &nbsp;<asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
