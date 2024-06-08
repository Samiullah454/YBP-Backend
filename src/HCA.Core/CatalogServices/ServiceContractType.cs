using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatalogServices
{
    public class ServiceContractType : FullAuditedEntity<int>
    {
        public ServiceContractType()
        {
            //CreationTime = DateTime.UtcNow;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ServiceContracts> ServiceContracts { get; set; }
    }
}
