using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeG3T2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemNaam { get; set; }
        public string Status { get; set; }
        public int KlantId { get; set; }
        public List<SensorData> SensorDataList { get; set; }
    }
}
