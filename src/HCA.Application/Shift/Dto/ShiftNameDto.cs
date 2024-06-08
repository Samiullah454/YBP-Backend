using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Shift.Dto
{
    [AutoMapFrom(typeof(Shifts))]

    public class ShiftNameDto : EntityDto<int>
    {
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<DayOfWeek> ShiftDays { get; set; }

    }
}
