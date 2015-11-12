using System;

public partial class Log_ud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("LoginForm.aspx");
    }
}


