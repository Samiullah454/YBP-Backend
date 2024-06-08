using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CrewGroup;
using HCA.Employee;
using HCA.TechnicinaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.TechnicianType.Dto
{
    [AutoMapFrom(typeof(TechnicianTypes))]

    public class TechnicianTypeDto : EntityDto<int>
    {
        public string TechnicianTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<Employee.Dto.TechnicianDto> Technicians { get; set; }
    }
}
