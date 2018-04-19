<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="frmManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Manage Users"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMngUserName" runat="server" Text="User Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtMngUserName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:" width="73px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtMngPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSecurityLevel" runat="server" Text="Security Level:" width="73px"></asp:Label>
&nbsp;<asp:DropDownList ID="drpSecurityLevel" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>U</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Add User" />
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="grdManageUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" 
            DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" 
            ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" 
          SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>

        </asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
