using Abp.Authorization.Users;
using Abp.MultiTenancy;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Authorization.Accounts.Dto
{
    public class CustomerProfileDto
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string Expiry { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string b_FirstName { get; set; }
        public string b_LastName { get; set; }
        public string b_Address { get; set; }
        public string b_State { get; set; }
        public string b_City { get; set; }
        public string b_ZipCode { get; set; }
    }
}
