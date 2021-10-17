using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Models;

namespace PaymentRuleEngine.App.Factory
{
    public class PaymentFactoryService : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
            throw new System.NotImplementedException();
        }
    }
}
