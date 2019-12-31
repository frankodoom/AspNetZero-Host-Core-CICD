using Abp.Notifications;
using tgtDemo.Dto;

namespace tgtDemo.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}