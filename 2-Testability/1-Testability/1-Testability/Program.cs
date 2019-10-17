using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcesser(new ShippingCalculator());
            var order = new Order { DataPlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
