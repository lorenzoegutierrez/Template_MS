using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_TMS_Application.Notifications
{
    public enum StatusCode
    {
        Ok = 200,
        Create = 201,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        UnprocessableEntity = 422
    }
}
