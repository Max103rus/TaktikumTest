namespace TaktikumTest.Services.Intefraces
{
    public interface ILogService
    {
        public Task LogRequestResponseAsync(HttpContext context, DateTime startTime);
    }
}
