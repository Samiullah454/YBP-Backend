using Abp.AutoMapper;
using Abp.Domain.Entities;
using HCA.CrewGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.ServiceArea.Dto
{
    [AutoMapFrom(typeof(ServiceAreas))]

    public class ServiceAreaNameDto :Entity<int>
    {
        public string ServiceAreaName { get; set; }

    }
}
