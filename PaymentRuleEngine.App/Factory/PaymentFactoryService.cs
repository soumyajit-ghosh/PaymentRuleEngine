using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Factory.ConcreateFactory;
using PaymentRuleEngine.App.Models;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Factory
{
    public class PaymentFactoryService : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
            switch (payment.Type)
            {
                case OrderTypes.Book:
                    BookPaymentFactory bookPaymentFactory = new BookPaymentFactory();
                    bookPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.PhysicalProduct:
                    PhysicalProductPaymentFactory physicalProductPaymentFactory = new PhysicalProductPaymentFactory();
                    physicalProductPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.Video:
                    VideoPaymentFactory videoPaymentFactory = new VideoPaymentFactory();
                    videoPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.Membership:
                    MembershipFactory membershipFactory = new MembershipFactory();
                    membershipFactory.PaymentMade(payment);
                    break;
            }
        }
    }
}
