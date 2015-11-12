using System;
using AKrepo;

public partial class HentEfterProducent : System.Web.UI.Page
{
    BilFac bf = new BilFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (Bil bil in bf.GetBy("ProducentID", 2))
        {
            litBiler.Text += bil.Model + "<br />";
        }
    }
}


