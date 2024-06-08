using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CrewGroup.Dto
{
    [AutoMapFrom(typeof(CrewGroups))]

    public class GrewGroupNameDto: Entity<int>
    {
        public string CrewGroupName { get; set; }
    }
}
