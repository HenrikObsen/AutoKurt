using System.Collections.Generic;

namespace AKrepo
{
    public class BilMedBilleder
    {
        public int ID { get; set; }
        public int ProducentID { get; set; }
        public string Model { get; set; }
        public string Beskrivelse { get; set; }
        public decimal Pris { get; set; }
        public List<Billede> Billeder { get; set; }
    }
}
