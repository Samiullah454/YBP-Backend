using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.WebSite_Configuration.Service
{
    public class Service : FullAuditedEntity<int>
    {
        public string IconClass { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
    }

    public class Pricing : FullAuditedEntity<int>
    {
        public string IconClass { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item : FullAuditedEntity<int>
    {
        public string Title { get; set; }
        public string IconClass { get; set; }

        [ForeignKey(nameof(PricingId))]
        public int PricingId { get; set; }

        public Pricing Pricing { get; set; }
    }

    public class Feature : FullAuditedEntity<int>
    {
        public string Title { get; set; }
        public string IconClass { get; set; }
        public string Description { get; set; }
    }

    public class Section : FullAuditedEntity<int>
    {
        public string? SectionTitle { get; set; }
        public string? SectionDescription { get; set; }
        public string SectionType { get; set; }
        public Boolean IsVisble { get; set; }
        public List<Service>? Services { get; set; }
        public List<Pricing>? Pricings { get; set; }
        public List<Feature>? Features { get; set; }
        public List<ScheduleItem>? ScheduleItems { get; set; }
        public List<FactAndFigure>? FactAndFigures { get; set; }
    }

    public class ScheduleItem : FullAuditedEntity<int>
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
    }

    public class FactAndFigure : FullAuditedEntity<int>
    {
        public string project { get; set; }
        public string developer { get; set; }
        public string client { get; set; }
        public string experince { get; set; }
    }
}