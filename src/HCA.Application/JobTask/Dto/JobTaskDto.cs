using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.JobTask.Dto
{
    [AutoMap(typeof(JobTasks))]
    public class JobTaskDto : EntityDto<int>
    {
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskStatuses Status { get; set; }
        public string Video { get; set; }
        public string VendorInfo { get; set; }
        public decimal RewardPKR { get; set; }
        public decimal StartingReward { get; set; }
        public List<string> CompletionProofs { get; set; }
        public string StallionComments { get; set; }
        public string Assignee { get; set; }
        public string TargetAudienceLevel { get; set; }
        public int NumberStallionsRequired { get; set; }
        public string TaskCategory { get; set; }
        public List<string> TargetStallionSkills { get; set; }
        public TimeSpan EstimatedDurationOfTask { get; set; }
        public bool IsRelatedToMarketing { get; set; }
        public List<AudienceType> TargetAudience { get; set; }
        public List<SocialMediaChannel> SocialMediaChannels { get; set; }
        public string ExpectedOutputResult { get; set; }
    }
}