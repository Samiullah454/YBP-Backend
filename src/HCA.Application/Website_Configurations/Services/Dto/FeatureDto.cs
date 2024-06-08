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
    [AutoMap(typeof(Feature))]
    public class FeatureDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string IconClass { get; set; }
        public string Description { get; set; }
    }
}