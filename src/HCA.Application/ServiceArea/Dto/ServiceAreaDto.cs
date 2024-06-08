using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HCA.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.ServiceArea.Dto
{
    [AutoMapFrom(typeof(ServiceAreas))]

    public class ServiceAreaDto :EntityDto<int>
    {
        public string ServiceAreaName { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public List<Employee.Dto.TechnicianDto> Technicians { get; set; }
    }
}
