using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DeliverFactory shipFactory = new ShipDeliveryFactory();
            Package p1 = new Package(shipFactory.GetDeliveryType());
            p1.ShipPackage(); 
            Console.WriteLine("Shipment Complete!");
            Console.ReadLine();
        }
    }
}
