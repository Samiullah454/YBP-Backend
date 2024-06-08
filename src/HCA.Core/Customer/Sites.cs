using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Customer
{
    public class Sites : FullAuditedEntity
    {

        public SiteType SiteType { get; set; }
        public Stories Stories { get; set; }
        public bool IsDefaultCustomer {  get; set; }
        public string Address { get; set; }
        public string GateCode { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsCellPhone { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]        // Navigation property
        public Customers Customer { get; set; }

    }
}
