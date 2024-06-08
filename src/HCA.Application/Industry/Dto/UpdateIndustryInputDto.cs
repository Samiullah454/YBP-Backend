using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry.Dto
{
    [AutoMapTo(typeof(Industry))]
    public class UpdateIndustryInputDto : CreateIndustryInputDto, IEntityDto<Guid>
    {
        public Guid Id { get; set; }
    }
}
