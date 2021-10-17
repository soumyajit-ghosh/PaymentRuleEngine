using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    public class MemberShip : IMembership
    {
        public void ActivateMembership()
        {
            Console.WriteLine("Activated Membership");
            Email email = new Email();
            email.SendActivation();

        }

        public void UpgradeMembership()
        {
            Console.WriteLine("Upgraded Membership");
            Email email = new Email();
            email.SendUpgrade();
        }
    }
}
