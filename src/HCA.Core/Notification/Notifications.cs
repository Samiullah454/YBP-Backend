using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Notification
{
    public class Notifications : Entity
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public bool IsRead { get; set; }
        public int FromUser { get; set; }
        public int ToUser { get; set; }
    }
}
