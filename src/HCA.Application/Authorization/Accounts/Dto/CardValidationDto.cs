using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Authorization.Accounts.Dto
{
    public class CardValidationDto
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string Expiry { get; set; }
        public float Amount { get; set; }

    }
}
