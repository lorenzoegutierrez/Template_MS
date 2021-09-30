using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_TMS_Domain.Notification
{
    public class ErrorResponse
    {
        public string Code { get; set; } = default!;
        public string? Id { get; set; }
        public string Message { get; set; } = default!;
        public List<Error> Errors { get; set; } = default!;
    }

    public class Error
    {
        public string ErrorCode { get; set; } = default!;
        public string Message { get; set; } = default!;
        public string? Path { get; set; }
        public string? Url { get; set; }
    }
}
