using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class JobChecklist : FullAuditedEntity<int>
    {
        public int ChecklistId { get; set; }
        public Checklist Checklist { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}