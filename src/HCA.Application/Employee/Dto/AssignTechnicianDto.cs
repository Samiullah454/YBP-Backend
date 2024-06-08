using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee.Dto
{
    public class AssignTechnicianDto
    {
        public int Id { get; set; }
        public string Caller { get; set; }
        public int[] TechniciansId { get; set; }
    }
}
