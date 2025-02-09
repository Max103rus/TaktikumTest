using TaktikumTest.Services.Intefraces;

namespace TaktikumTest.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogService _logService;

        public LoggingMiddleware(RequestDelegate next, ILogService logService)
        {
            _next = next;
            _logService = logService;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            await _logService.LogRequestResponseAsync(context, DateTime.UtcNow);
        }
    }
}
