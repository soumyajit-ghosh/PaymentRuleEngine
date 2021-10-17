using PaymentRuleEngine.App.Factory.AbstractFactory;
using PaymentRuleEngine.App.Interfaces;
using PaymentRuleEngine.App.Models;
using PaymentRuleEngine.App.Services;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Factory.ConcreateFactory
{
    public class MembershipFactory : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {

            switch (payment.OrderMode)
            {

                case OrderMode.ActivateMembership:
                    IMembership activateMembership = new MemberShip();
                    activateMembership.ActivateMembership();
                    break;

                case OrderMode.UpgradeMemebership:
                    IMembership upgradeMembership = new MemberShip();
                    upgradeMembership.UpgradeMembership();
                    break;
            }

            base.ReportingCollection();
        }
    }
}
