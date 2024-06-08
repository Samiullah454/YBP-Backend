using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CatalogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.DiagnosticServices.Dto
{
    [AutoMapTo(typeof(DiagnosticService))]

    public class DiagnosticServiceCreateOrUpdateDto:EntityDto<int>
    {
        public int? DiagnosticTypeID { get; set; }


        public string ServiceName { get; set; }

        public decimal? FlatServiceCallFee { get; set; }

        public bool IsAdjustedInRepairs { get; set; }

        public int TimeFrame { get; set; }

        public bool AdditionalDiagnosticsRequired { get; set; }


    }
}
