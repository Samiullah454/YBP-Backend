using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.TechnicinaType
{
    public class TechnicianTypes : FullAuditedEntity

    {
        public string TechnicianTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Technician> Technicians { get; set; }
    }
}
