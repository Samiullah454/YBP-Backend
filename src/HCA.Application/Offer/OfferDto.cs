using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Offer
{
    [AutoMap(typeof(Offers.Offer))]
    public class OfferDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OfferStartsOn { get; set; }
        public DateTime OfferEndsOn { get; set; }
        public string OfferGivenByInfo { get; set; }
        public int ClicksOnOffer { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Location { get; set; }
        public string VendorContact { get; set; }
        public TargetAudienceDto TargetAudience { get; set; }
        public int TargetReach { get; set; }
        public decimal OfferPostingPrice { get; set; }
        public string TransactionId { get; set; }
        public string TransactionReceiptScreenshot { get; set; }
        public int Views { get; set; }
    }

    [AutoMap(typeof(Offers.TargetAudience))]
    public class TargetAudienceDto : EntityDto<int>
    {
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}