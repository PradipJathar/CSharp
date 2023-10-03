using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //MethodName_Condition_Expectation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            Order order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }


        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Now.AddDays(1), order.Shipment.ShippingDate);

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
