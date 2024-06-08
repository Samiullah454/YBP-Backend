using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.WebSite_Configuration.Slider;
using System;
using System.Drawing;

namespace HCA.Website_Configurations.Sliders.Dto
{
    [AutoMap(typeof(Slider))]
    public class SliderDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string FocusedWord { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}