using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.SubSystems.Conversion;
using HCA.CrewGroup;
using HCA.Enumeration;
using HCA.Jobs;
using HCA.MultiTenancy;
using HCA.Packages;
using HCA.ServiceArea;
using HCA.Shift;
using HCA.TechnicinaType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee
{
    public class Technician : FullAuditedEntity
    {
        public Technician()
        {
            //CreationTime = DateTime.UtcNow;
        }
        public int? TechnicianTypeId { get; set; }
        [ForeignKey("TechnicianTypeId")]

        public TechnicianTypes TechnicianTypes { get; set; }

        public string TechnicianName { get; set; }
        public string ContactNumber { get; set; }
        public string Alt_ContactNumber { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public string Emr_ContactName { get; set; }
        public string Emr_ContactRelationship { get; set; }
        public string Emr_ContactPhone { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public CompensationType CompensationType { get; set; }
        public TechIncentiveType IncentiveType { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? HourlyRate { get; set; }
        
        [Column(TypeName = "decimal(7,2)")]
        public decimal? Salary { get; set; }
        
        [Column(TypeName = "decimal(7,2)")]
        public decimal? Inc_perJob { get; set; }
        
        [Column(TypeName = "decimal(7,2)")]
        public decimal? Inc_percentageJob { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? Inc_perHourJob { get; set; }

        public int? ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public Shifts Shifts { get; set; }
        public int? CrewGroupId { get; set; }
        [ForeignKey("CrewGroupId")]
        public CrewGroups CrewGroups { get; set; }
        public string DriverLicense { get; set; }
        public string SSN { get; set; }
        public DateTime DOB { get; set; }
        public int? ServiceAreasId { get; set; }
        [ForeignKey("ServiceAreasId")]

        public ServiceAreas ServiceAreas { get; set; }

        public virtual ICollection<Attachments> Attachments { get; set; }
        public virtual ICollection<TechnicianJob> TechnicianJobs { get; set; }
        public virtual ICollection<TechnicianServices> TechnicianServices { get; set; }


    }
}
