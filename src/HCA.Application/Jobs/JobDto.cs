using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CrewGroup;
using HCA.CrewGroup.Dto;
using HCA.Customer;
using HCA.Customer.Dto.CustomerDtos;
using HCA.Employee.Dto;
using HCA.Job.JobTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapFrom(typeof(Job))]
    public class JobDto : EntityDto<int>
    {
        public int? JobTypeId { get; set; }
        public JobtypeDto JobType { get; set; }

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
        public int? CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public int? CrewGroupId { get; set; }
        public CrewGroupDto CrewGroup { get; set; }

        public ICollection<TechnicianJobDto> TechnicianJob { get; set; }
        public ICollection<JobChecklistDto> JobChecklist { get; set; }
        public ICollection<JobServiceDto> JobService { get; set; }
    }
}
