namespace FactoryPattern{
    interface DeliverFactory{
        Delivery GetDeliveryType();
    }

    public class ShipDeliveryFactory : DeliverFactory
    {
        public Delivery GetDeliveryType()
        {
            return new ShipDelivery();
        }
    }

    public class TruckDeliveryFactory : DeliverFactory
    {
        public Delivery GetDeliveryType()
        {
            return new TruckDelivery();
        }
    }
}