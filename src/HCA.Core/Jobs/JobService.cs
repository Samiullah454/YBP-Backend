using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class JobService : FullAuditedEntity
    {
        public Services? Service { get; set; }
        public int? ServiceId { get; set; }
        public int? JobId { get; set; }
        public Job Job { get; set; }
    }
}
