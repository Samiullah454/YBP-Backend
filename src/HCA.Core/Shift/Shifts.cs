using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HCA.Employee;
using HCA.Enumeration;
using HCA.MultiTenancy;
using HCA.Subscription;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Shift
{
    public class Shifts : FullAuditedEntity
    {
        public Shifts()
        {
            //CreationTime = DateTime.UtcNow;
        }
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsActive { get; set; }
        public ShiftFrequency frequency { get; set; }
        //public int Capacity { get; set; }
        public string Notes { get; set; }
        public ShiftType ShiftType { get; set; }

        public ICollection<Technician> Technicians { get; set; }

        [NotMapped]
        public List<DayOfWeek> ShiftDays
        {
            get
            {
                if (string.IsNullOrEmpty(ShiftDaysCsv))
                {
                    return new List<DayOfWeek>();
                }

                return ShiftDaysCsv.Split(',').Select(d => (DayOfWeek)Enum.Parse(typeof(DayOfWeek), d)).ToList();
            }
            set => ShiftDaysCsv = String.Join(",", value ?? Enumerable.Empty<DayOfWeek>());
        }


        public string ShiftDaysCsv { get; set; } 
    }
}
