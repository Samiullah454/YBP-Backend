using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry.Dto
{
    [AutoMapFrom(typeof(Industry))]
    public class IndustryDto : EntityDto<Guid>
    {
        public string IndustryName { get; set; }
        public IndustryStatus Status { get; set; }
        public int PackageCount { get; set; }
        //public virtual ICollection<CustomSectionDto> CustomSections { get; set; }
    }
}
