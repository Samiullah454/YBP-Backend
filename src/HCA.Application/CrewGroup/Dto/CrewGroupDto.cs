using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Shift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CrewGroup.Dto
{
    [AutoMapFrom(typeof(CrewGroups))]

    public class CrewGroupDto : EntityDto<int>
    {
        public string CrewGroupName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<Employee.Dto.TechnicianDto> Technicians { get; set; }

    }
}
