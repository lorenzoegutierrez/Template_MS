using System.Text;

namespace Template_TMS_Application.Notifications
{
    public partial class ErrorTypeResult
    {
        protected ErrorTypeResult() { }

        public static ErrorType GetPageNumberIsNegative { get; set; } = new ErrorType
        {
            ErrorCode = CatalogErrorCodes.GetPageNumberIsNegative.ErrorCode,
            Reason = "[PageNumber] parameter number is negative or zero",
            MsgError = "[PageNumber] parameter wrong value"
        };

        public static ErrorType GetPageSizeIsNegative { get; set; } = new ErrorType
        {
            ErrorCode = CatalogErrorCodes.GetPageSizeIsNegative.ErrorCode,
            Reason = "[PageSize] parameter number is negative or zero",
            MsgError = "[PageSize] parameter wrong value"
        };
        public static ErrorType DescriptionIsNullOrEmpty { get; set; } = new ErrorType
        {
            ErrorCode = CatalogErrorCodes.DescriptionIsNullOrEmpty.ErrorCode,
            Reason = "[description] parameter is Null or empty",
            MsgError = "[description] parameter not set"
        };
        public static ErrorType TemperatureCIsNegative { get; set; } = new ErrorType
            {
                ErrorCode = CatalogErrorCodes.TemperatureCIsNegative.ErrorCode,
            Reason = "[temperatureC] parameter is negative",
            MsgError = "[description] parameter set than 0"
        };
        public static ErrorType InvalidModel { get; set; } = new ErrorType
        {
            ErrorCode = CatalogErrorCodes.InvalidModel.ErrorCode,
            Reason = "The model has more or less parameters than required",
            MsgError = "Invalid model"
        };
    }

    public class ErrorType
    {
        public string ErrorCode { get; set; } = default!;
        public string Reason { get; set; } = default!;
        public string MsgError { get; set; } = default!;

        public override string ToString()
        {
            return $"{ErrorCode} {MsgError}";
        }

        public static string GetProperties()
        {
            var sb = new StringBuilder();
            var type = typeof(ErrorTypeResult);
            var obj = new ErrorType();

            sb.AppendLine("| Error Code | Reason | Description |");
            sb.AppendLine("| -- | -- | -- |");

            foreach (var pInfo in type.GetProperties())
            {
                var errorType = (ErrorType)pInfo.GetValue(obj)!;

                sb.AppendLine($"| {errorType.ErrorCode} | {errorType.Reason} | {errorType.MsgError} |");
            }

            return sb.ToString();
        }
    }
}
