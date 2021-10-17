namespace PaymentRuleEngine.App.Interfaces
{
    interface ISlip
    {
        void GeneratePackingSlip();
        void GenerateDuplicatePackingSlip();
        void AddCouponToSlip();
    }
}
