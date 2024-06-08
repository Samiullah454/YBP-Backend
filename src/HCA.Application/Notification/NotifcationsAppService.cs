using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Notifications;

//using HCA.Migrations;
using HCA.Notification.Dto;
using HCA.Roles.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Notification
{
    public class NotifcationsAppService : AsyncCrudAppService<Notifications, NotificationsDto>
    {
        private readonly IRepository<Notifications> _notificationRepository;
        public NotifcationsAppService(IRepository<Notifications> repository)
           : base(repository)
        {
            _notificationRepository = repository;
        }

        public async Task<List<NotificationsDto>> GetAllNotifications()
        {
            var notifications = await _notificationRepository.GetAllListAsync();
            var notificationsList = ObjectMapper.Map<List<NotificationsDto>>(notifications);
            return notificationsList;
        }

        public async Task<List<NotificationsDto>> MarkAllAsRead(NotificationsDto reqDto)
        {
            var notifications = await _notificationRepository.GetAllListAsync();
            foreach (var notification in notifications.Where(item => item.ToUser == reqDto.ToUser))
            {
                notification.IsRead = true;
                await _notificationRepository.UpdateAsync(notification);
            }
            var notificationsList = ObjectMapper.Map<List<NotificationsDto>>(notifications);
            return notificationsList;
        }
    }
}
