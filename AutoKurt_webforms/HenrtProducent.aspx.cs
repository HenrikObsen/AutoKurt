using System;
using AKrepo;

public partial class HenrtProducent : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();
    Producent producent = new Producent();

    protected void Page_Load(object sender, EventArgs e)
    {
        producent = pf.Get(1);

        litProducent.Text = producent.Navn + "<br />";
        litProducent.Text += "<img src=\"Billeder/Producenter/" + producent.Logo + "\" />";
    }
}


