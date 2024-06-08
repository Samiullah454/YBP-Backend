using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Customer.Dto.SiteDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Customer.Dto.CustomerDtos
{
    [AutoMapFrom(typeof(Customers))]

    public class CustomerDto : EntityDto<int>
    {
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public bool IsCn_CellPhone { get; set; }
        public string AltCn_Number { get; set; }
        public bool IsAltCn_CellPhone { get; set; }
        public string Email { get; set; }
        public string HowHeardAboutUs { get; set; }
        public bool MarketingOptIn { get; set; }
        public List<SiteDto> Sites { get; set; }
    }
}
