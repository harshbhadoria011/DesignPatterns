using System;

namespace FactoryPattern{
    public class TruckDelivery : Delivery{
        public override void Deliver()
        {
            Console.WriteLine("Delivering package via Truck!");
        }
    }
}