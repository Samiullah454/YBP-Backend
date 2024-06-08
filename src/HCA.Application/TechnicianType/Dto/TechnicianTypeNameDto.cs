using Abp.AutoMapper;
using Abp.Domain.Entities;
using HCA.ServiceArea;
using HCA.TechnicinaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.TechnicianType.Dto
{
    [AutoMapFrom(typeof(TechnicianTypes))]

    public class TechnicianTypeNameDto:Entity<int>
    {
        public string TechnicianTypeName { get; set; }

    }
}
