using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    public class Email : IEmail
    {
        public void SendActivation()
        {
            Console.WriteLine("Sent Activation Email");
        }

        public void SendUpgrade()
        {
            Console.WriteLine("Sent Upgrade Email");
        }
    }
}
