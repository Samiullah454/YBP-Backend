using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.SubSystems.Conversion;
using HCA.Employee;
using HCA.Shift;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatalogServices
{
    public class DiagnosticService : FullAuditedEntity<int>
    {
        public DiagnosticService()
        {
            //CreationTime = DateTime.UtcNow;
        }

        public int? DiagnosticTypeID { get; set; }
        [ForeignKey("DiagnosticTypeID")]
        public DiagnosticType DiagnosticType { get; set; }
        public string ServiceName { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? FlatServiceCallFee { get; set; }
        public bool IsAdjustedInRepairs { get; set; }
        public int TimeFrame { get; set; }
        public bool AdditionalDiagnosticsRequired { get; set; }

        public int? RepairID { get; set; }
        [ForeignKey("RepairID")]
        public RepairService Repairs { get; set; }
        public virtual ICollection<WarrantyClaimService> WarrantyClaimService { get; set; }


    }
}
