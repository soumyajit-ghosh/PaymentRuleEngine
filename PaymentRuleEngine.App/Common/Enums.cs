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
