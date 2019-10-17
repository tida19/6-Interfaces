using System;

namespace _1_Testability
{
    public class OrderProcesser
    {
        public readonly IShippingCalculator _shippingCalculator;
        public OrderProcesser(IShippingCalculator shippingCalculater)
        {
            _shippingCalculator = shippingCalculater;

        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already Process.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }
    }
}
