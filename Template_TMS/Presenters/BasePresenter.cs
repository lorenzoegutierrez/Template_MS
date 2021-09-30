using Microsoft.AspNetCore.Mvc;

using Template_TMS_Api.Model;

using Template_TMS_Application.Notifications;

using Template_TMS_Domain.Notification;

namespace Template_TMS_Api.Presenters
{
    public class BasePresenter : IBasePresenter
    {
        public IActionResult GetResultEntity<T>(EntityResult<T> result) where T : class
        {
            if (!result.IsValid)
            {
                return CreateErrorActionResult(result);
            }
            else
            {
                return new JsonResult(result.Entity)
                {
                    StatusCode = (int?)result.StatusCode
                };
            }
        }
        public virtual IActionResult GetActionResult<T>(T result)
            where T : Result
        {
            if (!result.IsValid)
            {
                return CreateErrorResult(result);
            }

            return new OkResult();
        }

        public virtual IActionResult GetActionResult<T, Y>(T result)
            where Y : class
            where T : EntityResult<Y>
        {
            if (result.StatusCode != null)
            {
                return CreateErrorResult(result);
            }

            var res = new JsonResult(result.Entity)
            {
                StatusCode = (int?)StatusCode.Ok
            };

            return res;
        }

        protected virtual IActionResult CreateErrorResult<T>(T result)
            where T : Result
        {
            var errorBody = ApiError.FromResult(result);
            return result.StatusCode switch
            {
                StatusCode.BadRequest => new UnauthorizedObjectResult(errorBody),
                StatusCode.NotFound => new NotFoundObjectResult(errorBody),
                StatusCode.UnprocessableEntity => new UnprocessableEntityObjectResult(errorBody),
                StatusCode.Unauthorized => new UnauthorizedObjectResult(errorBody),
                StatusCode.Forbidden => new UnauthorizedObjectResult(errorBody),
                _ => new BadRequestObjectResult(errorBody)
            };
        }

        private JsonResult CreateErrorActionResult<T>(T result) where T : Result
        {
            var errors = new List<Error>() { };

            foreach (var notification in result.Notifications)
            {
                var error = new Error()
                {
                    ErrorCode = notification.Key,
                    Message = notification.Message
                };
                errors.Add(error);
            }

            return new JsonResult(
                new ErrorResponse()
                {
                    Message = result.StatusCode.ToString()!,
                    Code = ((int?)result.StatusCode).ToString()!,
                    Errors = errors
                }
                )
            {
                StatusCode = (int?)result.StatusCode
            };
        }
    }
}
