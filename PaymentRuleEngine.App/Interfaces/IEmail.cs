namespace PaymentRuleEngine.App.Interfaces
{
    interface IEmail
    {
        void SendActivation();
        void SendUpgrade();
    }
}
