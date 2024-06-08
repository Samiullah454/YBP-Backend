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

namespace HCA.CatelogServices.ServiceContract.Dto
{
    [AutoMapTo(typeof(ServiceContracts))]
    public class ServiceContractCreateOrUpdateDto :EntityDto<int>
    {
        public int? ServiceContractTypeID { get; set; }
        public string ServiceContractName { get; set; }
        public decimal? ContractPrice { get; set; }
        public bool IsProrated { get; set; }
        public bool IsRefundable { get; set; }
        public int? ContractPeriodByDays { get; set; }
        public int? ContractPeriodByMonths { get; set; }
        public int? ContractPeriodByYears { get; set; }
        public ContractFrequency Frequency { get; set; }
    }
}
