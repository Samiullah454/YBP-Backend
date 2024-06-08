using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee.Dto
{
    [AutoMapTo(typeof(Attachments))]
    public class AttachmentsCreateOrUpdateDto : EntityDto<int>
    {
        public AttachmentsCreateOrUpdateDto() {
          
        }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public AttachmentType FileType { get; set; }
        public byte[] FileContent { get; set; }
        public int TechnicianId { get; set; }
    }

}
