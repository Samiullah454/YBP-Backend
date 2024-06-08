using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee.Dto
{
    [AutoMapTo(typeof(Technician))]
    public class TechnicianCreateOrUpdateDto : EntityDto<int>
    {
        public int? TechnicianTypeId { get; set; }
        public string TechnicianName { get; set; }
        public string ContactNumber { get; set; }
        public string Alt_ContactNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Emr_ContactName { get; set; }
        public string Emr_ContactRelationship { get; set; }
        public string Emr_ContactPhone { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public CompensationType CompensationType { get; set; }
        public TechIncentiveType IncentiveType { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Inc_PerJob { get; set; }
        public decimal? Inc_PercentageJob { get; set; }
        public decimal? Inc_PerHourJob { get; set; }
        public int? ShiftId { get; set; }
        public int? CrewGroupId { get; set; }

        public string DriverLicense { get; set; }
        public string SSN { get; set; }
        public DateTime DOB { get; set; }
        public int? ServiceAreasId { get; set; }
        public int[]? IdsToDel { get; set; }
        public ICollection<TechnicianServicesCreateOrUpdateDto> TechnicianServices { get; set; }


    }

}
