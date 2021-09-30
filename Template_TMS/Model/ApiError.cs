using Flunt.Notifications;

using Template_TMS_Application.Notifications;

namespace Template_TMS_Api.Model
{
    public class ApiError
    {
        public IEnumerable<Notification> Notification { get; private set; }

        public ApiError(IEnumerable<Notification> notifications)
        {
            Notification = notifications;
        }

        public static ApiError FromResult(Result result)
        {
            return new ApiError(result.Notifications);
        }
    }
}
