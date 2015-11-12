using System;
using AKrepo;

public partial class SletProducent : System.Web.UI.Page
{
    ProducentFac pf = new ProducentFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        pf.Delete(3);

        litMsg.Text = "Producenten er slettet!!!";
    }
}

