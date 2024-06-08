using Abp.AutoMapper;
using HCA.CatalogServices;
using HCA.CatelogServices.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.WarrantyClaimServices.Dto
{
    [AutoMapFrom (typeof(WarrantyClaimServiceType))]
    public class WarrantyClaimServiceTypeDto:TypeBaseDto
    {
    }
}
