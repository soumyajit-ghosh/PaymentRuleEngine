using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine.App.Interfaces
{
    interface IEmail
    {
        void SendActivation();
        void SendUpgrade();
    }
}
