using System;
using AKrepo;

public partial class HentNavn : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        litOverskrift.Text = pf.GetName(1);
    }
}


