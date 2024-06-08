using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class JobType : FullAuditedEntity<int>
    {
        public JobType()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }

    }
}
