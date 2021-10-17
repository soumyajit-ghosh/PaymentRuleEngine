using PaymentRuleEngine.App.Models;

namespace PaymentRuleEngine.App.Factory.AbstractFactory
{
    public abstract class PaymentFactory
    {
        public abstract void PaymentMade(Payment payment);

        public void ReportingCollection()
        {
          // Event Sourcing And Logging
        }
    }
}
