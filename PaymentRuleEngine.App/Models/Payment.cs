using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
