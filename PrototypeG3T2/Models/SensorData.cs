using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeG3T2.Models
{
    public class SensorData
    {
        public int SensorDataId { get; set; }
        public string SensorNaam { get; set; }
        public double Vwaarde { get; set; }
        public bool Qwaarde { get; set; }
        public string Twaarde { get; set; }
        public int OrderId { get; set; }
    }
}
