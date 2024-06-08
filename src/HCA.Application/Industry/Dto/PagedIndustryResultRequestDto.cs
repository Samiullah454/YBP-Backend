using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry.Dto
{
    public class PagedIndustryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
