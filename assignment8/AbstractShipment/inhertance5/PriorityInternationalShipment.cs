using assignment8.AbstractShipment.class1;
using assignment8.AbstractShipment.inhertance3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8.AbstractShipment.inhertance5
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination,
             decimal customsFee, string destinationCountry) : base(trackingCode, description, weight, deliveryFee, destination, customsFee, destinationCountry)

        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for: {destinoationCountry}");
            Console.WriteLine($"Customs Fee: {customsFee}");
        }
    }
}





