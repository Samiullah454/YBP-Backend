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
    [AutoMapTo(typeof(JobService))]
    public class JobServiceCreateOrUpdateDto :EntityDto<int>
    {
        public Services? Service { get; set; }
        public int? ServiceId { get; set; }
        public int? JobId { get; set; }
    }
}
