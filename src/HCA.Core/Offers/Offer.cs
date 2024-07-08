using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Offers
{
    public class Offer : FullAuditedEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OfferStartsOn { get; set; }
        public DateTime OfferEndsOn { get; set; }
        public string OfferGivenBy { get; set; }
        public int ClicksOnOffer { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Location { get; set; }
        public string VendorContact { get; set; }
        public TargetAudience TargetAudience { get; set; }
        public int TargetReach { get; set; }
        public decimal OfferPostingPrice { get; set; }
        public string TransactionId { get; set; }
        public string TransactionReceiptScreenshot { get; set; }
        public int Views { get; set; }
        public bool IsApproved { get; set; }
    }
}