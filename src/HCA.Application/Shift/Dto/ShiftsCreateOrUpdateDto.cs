﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Shift.Dto
{
    [AutoMapTo(typeof(Shifts))]
    public class ShiftsCreateOrUpdateDto : EntityDto<int>
    {
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsActive { get; set; }
        public ShiftFrequency Frequency { get; set; }
        public string Notes { get; set; }
        public ShiftType ShiftType { get; set; }

        // New property
        public List<DayOfWeek> ShiftDays { get; set; }
    }
}
