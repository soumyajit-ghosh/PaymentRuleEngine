using PaymentRuleEngine.App.Interfaces;
using System;

namespace PaymentRuleEngine.App.Services
{
    public class Slip : ISlip
    {
        public void AddCouponToSlip()
        {
            Console.WriteLine("Added First Aid Video Free");
        }

        public void GenerateDuplicatePackingSlip()
        {
            Console.WriteLine("Generated Duplicate Payslip for Royality");
        }

        public void GeneratePackingSlip()
        {
            Console.WriteLine("Generated Paylip");
        }
    }
}
