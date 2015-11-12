using System;
using AKrepo;

public partial class OpretProducent : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();
    Producent producent = new Producent();

    protected void btnOpret_Click(object sender, EventArgs e)
    {
        producent.Navn = txtNavn.Text;
        producent.Logo = txtLogo.Text;

        pf.Insert(producent);

        litMsg.Text = "Producenten er oprettet!";
    }
}

