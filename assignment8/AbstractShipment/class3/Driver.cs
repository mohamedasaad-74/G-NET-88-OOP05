using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8.AbstractShipment.class3
{
    public class Driver
    {
        public string DriverId { get; set; }
        public string Name { get; set; }

        public Driver(string driverId, string name)
        {
            DriverId = driverId;
            Name = name;
        }
    }
}