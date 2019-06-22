using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeG3T2.Models
{
    public class Klant
    {
        public int KlantId { get; set; }
        public string BedrijfsNaam { get; set; }
        public string EmailAdres { get; set; }

        public List<Order> OrderList { get; set; }      
    }
}
