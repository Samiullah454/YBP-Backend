using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapTo(typeof(JobChecklist))]
    public class JobChecklistCreateOrUpdateDto :EntityDto<int>
    {
        public int ChecklistId { get; set; }
        public int JobId { get; set; }


    }
}
