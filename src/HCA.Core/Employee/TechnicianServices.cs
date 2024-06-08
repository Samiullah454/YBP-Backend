using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee
{
    public class TechnicianServices : FullAuditedEntity
    {
        public Services? Service { get; set; }
        public int?      ServiceId { get; set; }    
        public int? TechnicianId { get; set;}
        public Technician Technician { get; set; }  
    }
}
