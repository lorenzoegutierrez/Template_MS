using Microsoft.AspNetCore.Mvc;

using Template_TMS_Application.Notifications;

namespace Template_TMS_Api.Presenters
{
    public interface IBasePresenter
    {
        IActionResult GetActionResult<T, Y>(T result)
            where T : EntityResult<Y>
            where Y : class;
        IActionResult GetActionResult<T>(T result) where T : Result;
        IActionResult GetResultEntity<T>(EntityResult<T> result) where T : class;
    }
}
