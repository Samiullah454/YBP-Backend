using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapFrom(typeof(JobService))]
    public class JobServiceDto : EntityDto<int>
    {
        public Services? Service { get; set; }
        public int? ServiceId { get; set; }
        public int? JobId { get; set; }
    }
}
