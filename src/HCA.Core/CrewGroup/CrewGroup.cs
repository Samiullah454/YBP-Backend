using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CrewGroup
{
    public class CrewGroups :FullAuditedEntity
    {
        public CrewGroups() 
        { 
        }
        public string CrewGroupName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Technician> Technicians { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }


    }
}
