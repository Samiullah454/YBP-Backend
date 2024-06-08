using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class Checklist : FullAuditedEntity<int>
    {
        public Checklist()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<JobChecklist> JobChecklists { get; set; }

    }
}
