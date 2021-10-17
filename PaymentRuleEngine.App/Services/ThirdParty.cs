using PaymentRuleEngine.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
