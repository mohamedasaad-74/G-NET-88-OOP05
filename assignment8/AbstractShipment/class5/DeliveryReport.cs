using assignment8.AbstractShipment.interface1;
using assignment8.AbstractShipment.interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8.AbstractShipment.class5
{
    public class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public static void PrintShipment(IInsurable shipment)
        {
            Console.WriteLine($"IInsurable cost {shipment.CalculateInsurance()}");
        }

    }
}
