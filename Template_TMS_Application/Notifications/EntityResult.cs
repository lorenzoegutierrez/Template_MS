using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flunt.Notifications;

namespace Template_TMS_Application.Notifications
{
    public class EntityResult<T> : Result where T : class
    {
        public EntityResult(IReadOnlyCollection<Notification> notifications, T entity)
           : base(notifications)
        {
            Entity = entity;
        }

        public T Entity { get; }
    }
}
