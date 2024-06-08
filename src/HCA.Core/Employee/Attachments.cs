using Abp.Domain.Entities.Auditing;
using HCA.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee
{
    public class Attachments : FullAuditedEntity
    {
        public Attachments()
        {
            //CreationTime = DateTime.UtcNow;
        }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public AttachmentType FileType { get; set; }
        public byte[] FileContent { get; set; }
        public int TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        public virtual Technician Technician { get; set; }
    }
}
