using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Offers
{
    public class TargetAudience : FullAuditedEntity<int>
    {
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}