using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using HCA.Notification;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.States.DTO
{
    [AutoMap(typeof(State))]
    public class StateDto : EntityDto
    {
        public string StateName { get; set; }
    }
}
