using Abp.AutoMapper;
using HCA.CatalogServices;
using HCA.CatelogServices.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.DiagnosticServices.Dto
{
    [AutoMapTo(typeof(DiagnosticType))]
    public class DiagnosticTypeCreateOrUpdateDto : TypeBaseDto
    {
    }
}
