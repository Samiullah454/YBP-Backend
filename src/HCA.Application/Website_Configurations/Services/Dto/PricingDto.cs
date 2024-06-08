using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.WebSite_Configuration.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Services.Dto
{
    [AutoMap(typeof(Pricing))]
    public class PricingDto : EntityDto<int>
    {
        public string IconClass { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<ItemDto> Items { get; set; }
    }

    [AutoMap(typeof(Item))]
    public class ItemDto : EntityDto<int>
    {
        public string IconClass { get; set; }
        public string Title { get; set; }
    }
}