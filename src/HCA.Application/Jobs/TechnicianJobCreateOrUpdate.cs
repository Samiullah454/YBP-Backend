using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    [AutoMapTo(typeof(TechnicianJob))]
    public class TechnicianJobCreateOrUpdate : EntityDto<int>
    {
        public int TechnicianId { get; set; }

        public int JobId { get; set; }
    }
}
