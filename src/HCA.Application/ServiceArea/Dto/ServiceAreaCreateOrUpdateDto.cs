using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CrewGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.ServiceArea.Dto
{
    [AutoMapTo(typeof(ServiceAreas))]

    public class ServiceAreaCreateOrUpdateDto : EntityDto<int>
    
    {
        public string ServiceAreaName { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
