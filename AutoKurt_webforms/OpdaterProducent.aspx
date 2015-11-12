<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpdaterProducent.aspx.cs" Inherits="OpdaterProducent" %>

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
        <asp:Button ID="btnOpdater" runat="server" Text="Opdater" OnClick="btnOpdater_Click" />
    </div>
    </form>
</body>
</html>


