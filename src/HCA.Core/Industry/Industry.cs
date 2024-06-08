using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using HCA.MultiTenancy;
using HCA.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry
{
    public class Industry : FullAuditedEntity<Guid>
    {
        public Industry()
        {
            //CreationTime = DateTime.UtcNow;
        }

        public string IndustryName { get; set; }

        public IndustryStatus Status { get; set; }

        public virtual ICollection<Tenant> Tenants { get; set; }

        //public virtual ICollection<CustomSection> CustomSections { get; set; }

        public virtual ICollection<Package> Packages { get; set; }

    }
}
