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

namespace HCA.CatelogServices.WarrantyClaimServices.Dto
{
    [AutoMapFrom(typeof(WarrantyClaimService))]
    public class WarrantyClaimServiceDto:EntityDto<int>
    {
        public string ServiceName { get; set; }
        public int? WarrantyClaimServiceTypeId { get; set; }
        public int? DiagnosticServiceId { get; set; }
        public int? RepairServiceId { get; set; }
        public AssociatedServiceType AssociatedService { get; set; }
        public decimal ClaimServiceFee { get; set; }
    }
}
