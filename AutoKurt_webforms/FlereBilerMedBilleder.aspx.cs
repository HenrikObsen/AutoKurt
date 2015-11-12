using System;
using AKrepo;

public partial class FlereBilerMedBilleder : System.Web.UI.Page
{
    BilFac bf = new BilFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (BilMedBilleder bmb in bf.GetAllWithImages())
        {
            litBiler.Text += "<h1>" + bmb.Model + "</h1>";

            foreach (Billede billede in bmb.Billeder)
            {
                litBiler.Text += "<img src=\"Billeder/Biler/300/" + billede.Filnavn + " \" alt=\"" + billede.Alt + "\" />";

            }

            litBiler.Text += "<hr/>";
        }
    }
}

