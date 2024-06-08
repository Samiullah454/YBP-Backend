using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Leads
{
    public class Lead : Entity<int>
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