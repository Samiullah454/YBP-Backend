using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using HCA.States;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Cities.DTO
{
    [AutoMap(typeof(City))]
    public class CityDto : EntityDto
    {
        public int StateId { get; set; }
        public string CityName { get; set; }
    }
}