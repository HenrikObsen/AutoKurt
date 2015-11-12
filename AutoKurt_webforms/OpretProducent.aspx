<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpretProducent.aspx.cs" Inherits="OpretProducent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Navn: <asp:TextBox ID="txtNavn" runat="server" />
        <br/>
        Logo: <asp:TextBox ID="txtLogo" runat="server" />
        <br/>
        <asp:Button ID="btnOpret" runat="server" Text="Opret" OnClick="btnOpret_Click" />
        <asp:Literal ID="litMsg" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>

