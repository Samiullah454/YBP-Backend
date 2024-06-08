using Abp.Domain.Entities.Auditing;
using HCA.CrewGroup;
using HCA.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class Job : FullAuditedEntity<int>
    {
        public Job()
        {
         this.CreationDate = DateTime.Now;
        }
        public int? JobtypeId { get; set; }

        [ForeignKey("JobtypeId")]
        public JobType JobType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public double EstimatedHours { get; set; }
        public bool CrewRequired { get; set; }
        public string Description { get; set; }

        public bool InstrctionForTechnician { get; set; }
        public bool InstrctionForScheduler { get; set; }
        public string AdministratorNotes { get; set; }
        public bool ApprovalRequired { get; set; }

        public int? CrewGroupId { get; set; }
        public CrewGroups CrewGroup { get; set; }
        // Relationship: Job to Customer (One-to-Many)
        public int? CustomerId { get; set; }
        public Customers Customer { get; set; }

        // Relationship: Job to Technicians (Many-to-Many)
        public virtual ICollection<TechnicianJob> TechnicianJob { get; set; }

        // Relationship: Job to Checklist (Many-to-Many)
        public virtual ICollection<JobChecklist> JobChecklist { get; set; }
        public virtual ICollection<JobService> JobService { get; set; }

    }
}
