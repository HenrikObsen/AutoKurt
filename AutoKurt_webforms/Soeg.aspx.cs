using System;
using AKrepo;

public partial class Soeg : System.Web.UI.Page
{
    BilFac bf = new BilFac();

    protected void btnSoeg_Click(object sender, EventArgs e)
    {
        litSoeg.Text = "";

        foreach (Bil bil in bf.Search(txtKeyword.Text))
        {
            litSoeg.Text += bil.Model + "<br />";
        }
    }
}

