using System.Net;

namespace OneOfSample
{
    public class ApiResult
    {
        public ApiResult(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }
    }
}