using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.WebSite_Configuration.Logo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Logos
{
    [AutoMap(typeof(Logo))]
    public class LogoDto : EntityDto<int>
    {
        public string LogoUrl { get; set; }
    }
}