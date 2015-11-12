using System;
using AKrepo;

public partial class HentProducenter : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (Producent producent in pf.GetAll())
        {
            litProducenter.Text += producent.Navn + "<br />";
        }
    }
}

