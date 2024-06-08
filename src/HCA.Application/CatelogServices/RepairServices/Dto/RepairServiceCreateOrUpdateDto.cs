using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CatalogServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.RepairServices.Dto
{
    [AutoMapTo(typeof(RepairService))]
    public class RepairServiceCreateOrUpdateDto : EntityDto<int>
    {
        public int? RepairServiceTypeID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }

        public decimal? FlatRepairFee { get; set; }
        public int TimeFrame { get; set; }
        public int NumberOfTechs { get; set; }
        public bool WarrantyProvided { get; set; }
        public int WarrantyDays { get; set; }
    }
}
