using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.MultiTenancy;

namespace HCA.MultiTenancy.Dto
{
    [AutoMapTo(typeof(Tenant))]
    public class CreateTenantDto
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(AbpTenantBase.TenancyNameRegex)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(AbpTenantBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [StringLength(AbpTenantBase.MaxConnectionStringLength)]
        public string ConnectionString { get; set; }

        public bool IsActive { get; set; }

        //public string company { get; set; }
        public string username { get; set; }

        public string passowrd { get; set; }
        //public string purpose { get; set; }
        //public string teamsize { get; set; }
        //public string payment_methode { get; set; }
        //public string name_on_card { get; set; }

        //public string cardnumber { get; set; }
        //public string expiry { get; set; }
        //public string cvv { get; set; }
        //public bool savecard { get; set; }

        //public int package { get; set; }

        public string MobileNumber { get; set; }
        //public Guid IndustryId { get; set; }
    }
}