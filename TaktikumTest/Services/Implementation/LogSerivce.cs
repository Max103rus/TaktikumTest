using TaktikumTest.Models;
using TaktikumTest.Repositories.Interfaces;
using TaktikumTest.Services.Intefraces;

namespace TaktikumTest.Services.Implementation
{
    public class LogSerivce : ILogService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public LogSerivce(IServiceScopeFactory serviceScopeFactory)
        {
            _scopeFactory = serviceScopeFactory;
        }

        public async Task LogRequestResponseAsync(HttpContext context, DateTime startTime)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var logRepository = scope.ServiceProvider.GetRequiredService<ILogRepository>();

                var log = new Log
                {
                    RequestMethod = context.Request.Method,
                    RequestUrl = $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}{context.Request.QueryString}",
                    ResponseStatusCode = context.Response.StatusCode,
                    RequestTime = DateTime.UtcNow
                };
                await logRepository.AddLogAsync(log);
            }
        }
    }
}
