using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine.App.Common
{
    public class Enums
    {
        public enum OrderTypes
        {
            PhysicalProduct,
            Book,
            Video,
            Membership
        }

        public enum OrderMode
        {
            ActivateMembership,
            UpgradeMemebership
        }
    }
}
