namespace FactoryPattern{
    public class Package{
        private Delivery delivery;
        public Package(Delivery _delivery){
            delivery=_delivery;
        }
        public void ShipPackage(){
            delivery.Deliver();
        }
    }
}