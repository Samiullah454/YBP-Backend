using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Notification.Dto
{
    [AutoMap(typeof(Notifications))]
    public class NotificationsDto : EntityDto
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public bool IsRead { get; set; }
        public int FromUser { get; set; }
        public int ToUser { get; set; }
    }
}
