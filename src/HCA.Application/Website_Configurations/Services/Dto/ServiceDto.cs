using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.WebSite_Configuration.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Services.Dto
{
    [AutoMap(typeof(Service))]
    public class ServiceDTO : EntityDto<int>
    {
        public string IconClass { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    [AutoMap(typeof(ScheduleItem))]
    public class ScheduleItemDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
    }

    [AutoMap(typeof(FactAndFigure))]
    public class FactAndFigureDto : EntityDto<int>
    {
        public string project { get; set; }
        public string developer { get; set; }
        public string client { get; set; }
        public string experince { get; set; }
    }

    [AutoMap(typeof(Section))]
    public class SectionDTO : EntityDto<int>
    {
        public SectionDTO(List<ServiceDTO> services)
        {
            Services = services;
        }

        public string? SectionTitle { get; set; }
        public string? SectionDescription { get; set; }
        public string SectionType { get; set; }
        public Boolean IsVisble { get; set; }
        public List<ServiceDTO>? Services { get; set; }
        public List<PricingDto>? Pricings { get; set; }
        public List<FeatureDto>? Features { get; set; }
        public List<ScheduleItemDto>? ScheduleItems { get; set; }
        public List<FactAndFigureDto>? FactAndFigures { get; set; }
    }
}