using System;

namespace _1_Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DataPlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get
            {
                return Shipment != null;
            }
        }
    }
}
