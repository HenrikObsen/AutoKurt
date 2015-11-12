using System;
using System.Web.Security;
using AKrepo;

public partial class LoginForm : System.Web.UI.Page
{
    BrugerFac bf = new BrugerFac();

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string adgangskode = FormsAuthentication.HashPasswordForStoringInConfigFile(txtAdgangskode.Text.Trim(), "sha1");

        Bruger bruger = bf.LogIn(email, adgangskode);

        if (bruger.ID > 0)
        {
            Session.Timeout = 120;
            Session["UserID"] = bruger.ID.ToString();
            Session["UserName"] = bruger.Navn;
            Session["Type"] = bruger.Type;

            Response.Redirect("SidemedSikkerhed.aspx");
        }
        else
        {
            litMsg.Text = "Brugerne blev ikke fundet!";
        }
    }
}

