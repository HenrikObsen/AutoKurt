using System;

public partial class SideMedSikkerhed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("LoginForm.aspx");
        }
    }
}

