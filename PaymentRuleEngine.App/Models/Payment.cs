using System.ComponentModel.DataAnnotations;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App.Models
{
    public class Payment
    {
        [Required]
        public OrderTypes Type { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public OrderMode OrderMode { get; set; }

    }
}
