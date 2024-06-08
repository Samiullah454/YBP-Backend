using Abp.AutoMapper;
using HCA.CatelogServices.Type;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Job.Checklists.Dto
{
    [AutoMapFrom(typeof(Checklist))]
    public class ChecklistDto : TypeBaseDto
    {
    }
}
