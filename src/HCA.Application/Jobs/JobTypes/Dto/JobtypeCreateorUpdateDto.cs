using Abp.AutoMapper;
using HCA.CatelogServices.Type;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Job.JobTypes.Dto
{
    [AutoMapTo(typeof(JobType))]
    public class JobtypeCreateorUpdateDto : TypeBaseDto
    {
    }
}
