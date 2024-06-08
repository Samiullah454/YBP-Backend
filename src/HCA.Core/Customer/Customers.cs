using Abp.Domain.Entities.Auditing;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Customer
{
    public class Customers : FullAuditedEntity
    {

        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public bool IsCn_CellPhone { get; set; }
        public string AltCn_Number { get; set; }
        public bool IsAltCn_CellPhone { get; set; }
        public string Email { get; set; }
        public string HowHeardAboutUs { get; set; }
        public bool MarketingOptIn { get; set; }
        public ICollection<Sites> Sites { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }


    }
}
