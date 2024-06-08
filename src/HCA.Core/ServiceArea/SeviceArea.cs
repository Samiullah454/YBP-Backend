using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.ServiceArea
{
    public class ServiceAreas : FullAuditedEntity
    {
        public string ServiceAreaName { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public ICollection<Technician> Technicians { get; set; }

    }
}
