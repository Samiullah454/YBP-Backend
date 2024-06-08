using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Employee;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee.Dto
{
    [AutoMapTo(typeof(TechnicianServices))]
    public class TechnicianServicesCreateOrUpdateDto : EntityDto<int>
    {
        public Services? Service { get; set; }
        public int? ServiceId { get; set; }
        public int? TechnicianId { get; set; }
    }
}
