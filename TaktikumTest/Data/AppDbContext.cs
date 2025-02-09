using Microsoft.EntityFrameworkCore;
using TaktikumTest.Models;

namespace TaktikumTest.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Element> Elements { get; set; } = null!;
        public DbSet<Log> Logs { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
