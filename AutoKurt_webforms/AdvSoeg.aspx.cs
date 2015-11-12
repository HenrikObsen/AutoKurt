using System;
using System.Collections.Generic;
using AKrepo;
using System.Web.UI.WebControls;

public partial class AdvSoeg : System.Web.UI.Page
{
    BilFac bf = new BilFac();
    ProducentFac pf = new ProducentFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlProducent.Items.Add(new ListItem("Alle producenter","0"));

            foreach (Producent prod in pf.GetAll())
            {
                ddlProducent.Items.Add(new ListItem(prod.Navn, prod.ID.ToString()));
            }
            ddlProducent.SelectedIndex = 0;
        }
    }

    protected void btnSoeg_Click(object sender, EventArgs e)
    {
        List<Bil> listBiler = bf.AdvSearch(ddlProducent.SelectedItem.Value, txtMaxpris.Text, txtKeyword.Text);

        if (listBiler.Count > 0)
        {
            litResultat.Text = "";

            foreach (Bil bil in listBiler)
            {
                litResultat.Text += bil.Model + " " + bil.Pris + "<br/>";
            }
        }
        else
        {
            litResultat.Text = "Der blev ikke fundet noget på din søgning!!!";
        }       
    }
}