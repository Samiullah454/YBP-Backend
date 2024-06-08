using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Subscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Subscriptions
{
    [AutoMap(typeof(TenantPackageSubscription))]
    public class TenantPackageSubscriptionDto : EntityDto
    {
        public int TenantId { get; set; }
        public int PackageId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public string PaymentgatewayTransactionId { get; set; }
        public bool AutoRenew { get; set; }
        public DateTime CreationTime { get; set; }

        public string PackageName { get; set; }
        public int TeamMembers { get; set; }
        public int SMSCredits { get; set; }
        public int SMSSender { get; set; }
        public int MinTeamMembers { get; set; }
        public int Contacts { get; set; }
        public int Templates { get; set; }
        public int Broadcasts { get; set; }
        public double PackagePrice { get; set; }
        public double AddTeamMemberPrice { get; set; }
        public double AddNumberPrice { get; set; }
        public double AddCreditPrice { get; set; }

    }
}
