using PaymentRuleEngine.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
