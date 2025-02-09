using TaktikumTest.Data;
using TaktikumTest.Models;
using TaktikumTest.Repositories.Interfaces;

namespace TaktikumTest.Repositories.Implementation
{
    public class LogRepository : ILogRepository
    {
        private readonly AppDbContext _context;

        public LogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddLogAsync(Log log)
        {
            _context.Logs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
