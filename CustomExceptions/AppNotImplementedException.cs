using Microsoft.AspNetCore.Diagnostics;
using service_generator.EntityObjects;

namespace service_generator.CustomExceptions
{
    public class AppNotImplementedException : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is NotImplementedException)
            {
                var response = new OutputResponse()
                {
                    Status = httpContext.Response.StatusCode,
                    Message = exception.Message,
                };
                await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
                httpContext.Response.StatusCode = StatusCodes.Status501NotImplemented;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
