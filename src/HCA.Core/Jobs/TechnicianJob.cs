using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class TechnicianJob : FullAuditedEntity<int>
    {
        public int TechnicianId { get; set; }
        public Technician Technician { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
