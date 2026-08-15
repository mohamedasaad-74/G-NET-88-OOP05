using assignment8.AbstractShipment.class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8.AbstractShipment.inhertance4
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress deliveryAddress)
            : base(trackingCode, description, weight, deliveryFee, deliveryAddress)
        {

        }
        public override decimal EstimatedCost
        {
            get { return (decimal)weight * deliveryfee; }
        }
public override void PrintShipment()
        {
            Console.WriteLine($"Completed code : {trackingcode} Cost {EstimatedCost}");
        }


    }
}