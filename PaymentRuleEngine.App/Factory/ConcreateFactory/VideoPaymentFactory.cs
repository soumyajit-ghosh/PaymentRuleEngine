using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Interfaces;
using PaymentRuleEngine.App.Models;
using PaymentRuleEngine.App.Services;

namespace PaymentRuleEngine.App.Factory.ConcreateFactory
{
    public class VideoPaymentFactory : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
            ISlip slip = new Slip();
            slip.AddCouponToSlip();
            slip.GeneratePackingSlip();

            base.ReportingCollection();
        }
    }
}
