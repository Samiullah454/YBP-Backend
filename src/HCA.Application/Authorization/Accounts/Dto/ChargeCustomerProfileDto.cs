using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Authorization.Accounts.Dto
{
    public class ChargeCustomerProfileDto
    {
        public string CustomerProfileId { get; set; }
        public string PaymentProfileId { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
