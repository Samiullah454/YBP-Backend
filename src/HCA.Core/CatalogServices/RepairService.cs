using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatalogServices
{
    public class RepairService : FullAuditedEntity<int>
    {
        public RepairService()
        {
            //CreationTime = DateTime.UtcNow;
        }

        public int? RepairServiceTypeID { get; set; }
        [ForeignKey("RepairServiceTypeID")]
        public RepairServiceType RepairServiceType { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? FlatRepairFee { get; set; }
        public int TimeFrame { get; set; }
        public int NumberOfTechs { get; set; }
        public bool WarrantyProvided { get; set; }
        public int WarrantyDays { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<DiagnosticService> DiagnosticService { get; set; }
        public virtual ICollection<WarrantyClaimService> WarrantyClaimService { get; set; }

    }

}
