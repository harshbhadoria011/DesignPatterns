using System;

namespace FactoryPattern{
    public class ShipDelivery : Delivery{
        public override void Deliver()
        {
            Console.WriteLine("Delivering package via Ship!");
        }
    }
}