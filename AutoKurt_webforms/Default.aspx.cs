using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class _Default : System.Web.UI.Page
{
    BilServiceClient bsc = new BilServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        Bil b = new Bil();

        b.Beskrivelse = "Test";
        b.Model = "Test";
        b.Pris = 2000;
        b.ProducentID = 3;
        bsc.AddCar(b);
     

        foreach (Bil bil in bsc.GetAllCars())
        {
            litData.Text += bil.Model + "<br>";
        }
    }
}