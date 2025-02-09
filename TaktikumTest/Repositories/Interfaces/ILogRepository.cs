using TaktikumTest.Models;

namespace TaktikumTest.Repositories.Interfaces
{
    public interface ILogRepository
    {
        public Task AddLogAsync(Log log);
    }
}
