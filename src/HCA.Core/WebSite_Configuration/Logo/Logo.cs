using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.WebSite_Configuration.Logo
{
    public class Logo : FullAuditedEntity<int>
    {
        public string LogoUrl { get; set; }
    }
}