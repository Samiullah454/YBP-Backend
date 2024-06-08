using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee.Dto
{
    public class GetAllAttachmentsInput : PagedAndSortedResultRequestDto
    {
        public int? TechnicianId { get; set; }
    }
}
