using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatalogServices
{
    public class WarrantyClaimService : FullAuditedEntity<int>
    {
        public string ServiceName { get; set; }
        public int? WarrantyClaimServiceTypeId { get; set; }
        [ForeignKey("WarrantyClaimServiceTypeId")]
        public WarrantyClaimServiceType WarrantyClaimServiceType { get; set; }
        public int? DiagnosticServiceId { get; set; }
        [ForeignKey("DiagnosticServiceId")]
        public DiagnosticService DiagnosticService { get; set; }
        public int? RepairServiceId { get; set; }
        [ForeignKey("RepairServiceId")]
        public RepairService RepairService { get; set; }
        public AssociatedServiceType AssociatedService { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal ClaimServiceFee { get; set; }
    }
}
