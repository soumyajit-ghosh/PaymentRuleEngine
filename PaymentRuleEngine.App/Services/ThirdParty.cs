using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    public class ThirdParty : IThirdParty
    {
        public void AddCommissionToAgent()
        {
            Console.WriteLine("Added commission to agent");
        }
    }
}
