using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapFrom(typeof(JobChecklist))]
    public class JobChecklistDto :EntityDto<int>
    {
        public int ChecklistId { get; set; }
        public int JobId { get; set; }
    }
}
