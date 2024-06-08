using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CrewGroup;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Customer.Dto.SiteDtos
{
    [AutoMapFrom(typeof(Sites))]

    public class SiteDto : EntityDto<int>
    {
        public SiteType SiteType { get; set; }
        public Stories Stories { get; set; }
        public bool IsDefaultCustomer { get; set; }
        public string Address { get; set; }
        public string GateCode { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsCellPhone { get; set; }
    }
}
