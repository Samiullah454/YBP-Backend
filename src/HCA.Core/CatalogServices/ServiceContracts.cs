using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.SubSystems.Conversion;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatalogServices
{
    public class ServiceContracts : FullAuditedEntity<int>
    {
        public ServiceContracts()
        {
            //CreationTime = DateTime.UtcNow;
        }

        public int? ServiceContractTypeID { get; set; }
        [ForeignKey("ServiceContractTypeID")]
        public ServiceContractType ServiceContractType { get; set; }
        public string ServiceContractName { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? ContractPrice { get; set; }
        public bool IsProrated { get; set; }
        public bool IsRefundable{ get; set; }
        public int? ContractPeriodByDays { get; set; }
        public int? ContractPeriodByMonths { get; set; }
        public int? ContractPeriodByYears { get; set; }
        public ContractFrequency Frequency { get; set; }
    }
}
