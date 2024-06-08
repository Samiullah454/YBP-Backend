using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CatalogServices;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.Parts.Dto
{
    [AutoMapFrom(typeof(CatalogServices.Part))]
    public class PartDto: EntityDto<int>
    {
        public int? PartTypeId { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        public string Manufacturer { get; set; }
        public string ManufpartNo { get; set; }

        public int ShippingDays { get; set; }
        public bool IsBackOrdered { get; set; }

        public string TAskSKU { get; set; }
        public decimal ManufacturerPrice { get; set; }
        public decimal TAPrice { get; set; }
        public MarkupType MarkupType { get; set; }
        public decimal MarkupAmount { get; set; }


        public WarrantyDuration ManufWaDuration { get; set; }
        public int MaufWarranty { get; set; }
        public WarrantyDuration TAWaDuration { get; set; }
        public int TAWarranty { get; set; }

        public SecAdvAmtType SecAdvAmtType { get; set; }
        public decimal SecAdvAmount { get; set; }
    }
}
