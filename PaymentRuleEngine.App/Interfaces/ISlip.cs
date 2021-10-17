using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine.App.Interfaces
{
    interface ISlip
    {
        void GeneratePackingSlip();
        void GenerateDuplicatePackingSlip();
        void AddCouponToSlip();
    }
}
