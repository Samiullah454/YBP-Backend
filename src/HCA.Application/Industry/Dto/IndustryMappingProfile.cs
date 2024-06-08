using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry.Dto
{
    public class IndustryMappingProfile : Profile
    {
        public IndustryMappingProfile()
        {
            //CreateMap<CustomSection, CustomSectionDto>();
            CreateMap<Industry, IndustryDto>();
            //.ForMember(dest => dest.CustomSections, opt => opt.MapFrom(src => src.CustomSections));           
        }
    }
}
