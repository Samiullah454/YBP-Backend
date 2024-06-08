using Abp.MultiTenancy;
using HCA.Authorization.Users;
using HCA.Shift;
using HCA.Subscription;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCA.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }

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
        //public string MobileNumber { get; set; }
        //public Guid IndustryId { get; set; }
        //[ForeignKey("IndustryId")]
        //public Industry.Industry Industry { get; set; }

        //public ICollection<TenantPackageSubscription> tenantSubscriptions { get; set; }
        //public ICollection<Shifts> Shifts { get; set; }
    }
}