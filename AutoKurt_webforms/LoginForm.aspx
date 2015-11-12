<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        E-mail: <asp:TextBox ID="txtEmail" runat="server" />
        <br/>
        Adgangskode: <asp:TextBox ID="txtAdgangskode" runat="server" />
        <br/>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><asp:Literal ID="litMsg" runat="server" />
    </div>
    </form>
</body>
</html>

