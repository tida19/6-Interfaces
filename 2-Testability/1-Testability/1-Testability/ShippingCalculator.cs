using System;

namespace _1_Testability
{


    public class ShippingCalculator : IShippingCalculator
    {
        public float CalCulateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }

        public float CalculateShipping(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
