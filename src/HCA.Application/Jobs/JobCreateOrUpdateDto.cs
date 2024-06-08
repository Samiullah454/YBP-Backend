using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CrewGroup;
using HCA.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapTo(typeof(Job))]
    public class JobCreateOrUpdateDto : EntityDto<int>
    {
        public int JobTypeId { get; set; }
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
        public int CustomerId { get; set; }
        public int? CrewGroupId { get; set; }

        public int[]? TechnicianJobIds { get; set; }
        public int[]? JobChecklistIds { get; set; }
        public int[]? JobServiceIds { get; set; }
        public ICollection<TechnicianJobCreateOrUpdate> TechnicianJob { get; set; }
        public ICollection<JobChecklistCreateOrUpdateDto> JobChecklist { get; set; }
        public ICollection<JobServiceCreateOrUpdateDto> JobService { get; set; }
    }
}
