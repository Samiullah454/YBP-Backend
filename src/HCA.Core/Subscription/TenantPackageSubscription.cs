using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using HCA.MultiTenancy;
using HCA.Packages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Subscription
{
    public class TenantPackageSubscription : FullAuditedEntity
    {

        //public int TenantId { get; set; }
        //public int PackageId { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        //public bool Status { get; set; }
        //public bool PaymentStatus { get; set; }
        //public DateTime LastPaymentDate { get; set; }
        //public DateTime NextPaymentDate { get; set; }
        //public string PaymentgatewayTransactionId { get; set; }
        //public bool AutoRenew { get; set; }
        //public DateTime CreationTime { get; set; }

        //public string PackageName { get; set; }
        //public int TeamMembers { get; set; }
        //public int SMSCredits { get; set; }
        //public int SMSSender { get; set; }
        //public int MinTeamMembers { get; set; }
        //public int Contacts { get; set; }
        //public int Templates { get; set; }
        //public int Broadcasts { get; set; }
        //public double PackagePrice { get; set; }
        //public double AddTeamMemberPrice { get; set; }
        //public double AddNumberPrice { get; set; }
        //public double AddCreditPrice { get; set; }


        //[ForeignKey(nameof(TenantId))]
        //public Tenant subscribeTenant { get; set; }

        //[ForeignKey(nameof(PackageId))]
        //public Package subscribePackage { get; set; }

        public TenantPackageSubscription()
        {
            //CreationTime = DateTime.UtcNow;
        }
        public bool? IsTrial { get; set; }

        public DateTime? SubscriptionDate { get; set; }

        public int? AdditionalSysUsers { get; set; }

        public int? AdditionalTechs { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal? PricePerTech { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal? PricePerSysUser { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public int PackageId { get; set; }

        [ForeignKey("PackageId")]
        public Package subscribePackage { get; set; }
        public int? TenantId { get; set; }

        [ForeignKey("TenantId")]
        public Tenant Tenant { get; set; }
    }
}
