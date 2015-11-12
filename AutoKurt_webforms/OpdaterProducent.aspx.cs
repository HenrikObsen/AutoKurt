using System;
using AKrepo;

public partial class OpdaterProducent : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();
    Producent producent = new Producent();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            producent = pf.Get(2);

            txtNavn.Text = producent.Navn;
            txtLogo.Text = producent.Logo;
        }
    }

    protected void btnOpdater_Click(object sender, EventArgs e)
    {
        producent.Navn = txtNavn.Text;
        producent.Logo = txtLogo.Text;
        producent.ID = 2;

        pf.Update(producent);

        Response.Redirect("OpdaterProducent.aspx");
    }
}


