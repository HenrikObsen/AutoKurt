using System;
using AKrepo;

public partial class HenrtBilerMedProducent : System.Web.UI.Page
{
    BilFac bf = new BilFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (BilMedProducent bmp in bf.GetAllBilMedProducent())
        {
            litBiler.Text += bmp.ProducentNavn + " " + bmp.Model + "<br/>";
        }
    }
}

