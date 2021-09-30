
using Flunt.Notifications;

namespace Template_TMS_Application.Notifications
{
    public class Result : Notifiable<Notification>
    {
        public Result(string error)
        {
            AddNotification((Type)null!, error);
        }

        public Result(IReadOnlyCollection<Notification> notifications)
        {
            AddNotifications(notifications);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications, StatusCode errorCode)
        {
            AddNotifications(notifications);
            StatusCode = errorCode;
        }

        public void AddNotification(string error, StatusCode errorCode)
        {
            AddNotification((Type)null!, error);
            StatusCode = errorCode;
        }

        public void AddNotification(string property, string message, StatusCode errorCode)
        {
            AddNotification(property, message);
            StatusCode = errorCode;
        }

        public void AddNotification(string error)
        {
            AddNotification((Type)null!, error);
        }

        public void AddNotification(Notification notification, StatusCode errorCode)
        {
            AddNotification(notification);
            StatusCode = errorCode;
        }

        public StatusCode? StatusCode { get; set; }
    }
}
