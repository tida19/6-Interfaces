using System;
using _1_Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestabilityTest
{
    [TestClass]
    public class OrderProcesserTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProcess = new OrderProcesser(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcess.Process(order);
        }
        [TestMethod]
        public void Porcess_OrderIsNotShipped_shouldSetTheShip()
        {
            var orderProcess = new OrderProcesser(new FakeShippingCalculator());
            var order = new Order();

            orderProcess.Process(order);

            Assert.IsTrue(order.IsShipped);
            //Assert.AreEqual(1,order.Shipment);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);


        }
    }
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
