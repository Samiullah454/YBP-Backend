using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using HCA.Packages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Transactions.DTO
{
    [AutoMap(typeof(Transactions))]
    public class TransactionDto : EntityDto
    {
        public int TenantId { get; set; }
        public string PaymentProfileId { get; set; }
        public string PaymentTransactionId { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaymentType { get; set; }
        public string AuthCode { get; set; }
        public double PaidAmount { get; set; }
        public int? AddSentSMSCount { get; set; }
        public double? AddSentSMSPrice { get; set; }
        public int? AddReceiveSMSCount { get; set; }
        public double? AddReceiveSMSPrice { get; set; }
        public int? AddUserCount { get; set; }
        public double? AddUserPrice { get; set; }
        public int? AddNumberCount { get; set; }
        public double? AddNumberPrice { get; set; }
        public int? PreviousPackageId { get; set; }
        public int? CurrentPackageId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
