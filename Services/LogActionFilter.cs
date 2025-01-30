using Microsoft.AspNetCore.Mvc.Filters;

namespace service_generator.Services
{
    public class LogActionFilter : IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;

        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.Controller.GetType().Name.Replace("Controller", "");
            var action = context.ActionDescriptor.DisplayName;

            _logger.LogInformation("Completed request on {Controller}: {Action}", controller, action);

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller.GetType().Name.Replace("Controller", "");
            var action = context.ActionDescriptor.DisplayName;
            _logger.LogInformation("Processing request in {Controller}: {Action}", controller, action);
        }


    }
}
