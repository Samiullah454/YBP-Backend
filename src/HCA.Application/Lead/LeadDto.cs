using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Lead
{
    [AutoMap(typeof(Leads.Lead))]
    public class LeadDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string WhatsappNumber { get; set; }
        public string Cnic { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ReferredBy { get; set; }
        public bool Privacy { get; set; }
    }
}