using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.CatalogServices;
using HCA.CrewGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.DiagnosticServices.Dto
{
    [AutoMapFrom(typeof(DiagnosticService))]

    public class DiagnosticServiceDto : EntityDto<int>
    {
        public int? DiagnosticTypeID { get; set; }


        public string ServiceName { get; set; }

        public decimal? FlatServiceCallFee { get; set; }

        public bool IsAdjustedInRepairs { get; set; }

        public int TimeFrame { get; set; }

        public bool AdditionalDiagnosticsRequired { get; set; }
    }
}
