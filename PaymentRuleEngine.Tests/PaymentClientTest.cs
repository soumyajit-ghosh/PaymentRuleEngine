using NUnit.Framework;
using PaymentRuleEngine.App.Factory;
using PaymentRuleEngine.App.Models;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.Tests
{
    public class PaymentClientTest
    {
        private readonly PaymentFactoryService makePayment;
        [SetUp]
        public void Setup()
        {
            var makePayment = new PaymentFactoryService();
        }

        [Test]
        public void PaymentClient_OrderBook()
        {
            var payment = new Payment() { Type = OrderTypes.Book, Amount = 500};   
            makePayment.PaymentMade(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderPhysicalProduct()
        {
            var payment = new Payment() { Type = OrderTypes.PhysicalProduct, Amount = 100 };
            makePayment.PaymentMade(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderVideo()
        {
            var payment = new Payment() { Type = OrderTypes.Video, Amount = 200 };
            makePayment.PaymentMade(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderMembershlipActivate()
        {
            var payment = new Payment() { Type = OrderTypes.Membership, Amount = 999, OrderMode = OrderMode.ActivateMembership };
            makePayment.PaymentMade(payment);

            Assert.Pass();
        }
        [Test]
        public void PaymentClient_OrderMembershlipUpgrade()
        {
            var payment = new Payment() { Type = OrderTypes.Membership, Amount = 899, OrderMode = OrderMode.UpgradeMemebership };
            makePayment.PaymentMade(payment);

            Assert.Pass();
        }
    }
}