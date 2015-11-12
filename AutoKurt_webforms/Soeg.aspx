<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Soeg.aspx.cs" Inherits="Soeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Søg</h1>
        <asp:TextBox ID="txtKeyword" runat="server" />
        <asp:Button ID="btnSoeg" runat="server" Text="Søg" OnClick="btnSoeg_Click" />
        <hr/>
        <asp:Literal ID="litSoeg" runat="server" />
    </div>
    </form>
</body>
</html>

