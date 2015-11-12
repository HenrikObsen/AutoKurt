using System;
using AKrepo;

public partial class EnBilMedBilleder : System.Web.UI.Page
{
    BilFac bf = new BilFac();
    BilMedBilleder bmb = new BilMedBilleder();

    protected void Page_Load(object sender, EventArgs e)
    {
        bmb = bf.GetWithImages(3);

        litBil.Text = "<h1>" + bmb.Model + "</h1>";

        if (bmb.Billeder.Count > 0)
        {
            foreach (Billede billede in bmb.Billeder)
            {
                litBil.Text += "<img src=\"Billeder/Biler/300/" + billede.Filnavn + " \" alt=\"" + billede.Alt + "\" />";
            }
        }

    }
}

