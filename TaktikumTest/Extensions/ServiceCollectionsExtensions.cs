using Microsoft.EntityFrameworkCore;
using TaktikumTest.Data;
using TaktikumTest.Data.Interfaces;
using TaktikumTest.Repositories.Implementation;
using TaktikumTest.Repositories.Interfaces;
using TaktikumTest.Repository.Implementation;
using TaktikumTest.Services.Implementation;
using TaktikumTest.Services.Intefraces;

namespace TaktikumTest.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddDatabase(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
            return builder;
        }

        public static WebApplicationBuilder AddElementsRepository(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IElementsRepository, ElementsRepository>();
            return builder;
        }

        public static WebApplicationBuilder AddLogRepository(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ILogRepository, LogRepository>();
            return builder;
        }

        public static WebApplicationBuilder AddElementService(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IElementService, ElementService>();
            return builder;
        }

        public static WebApplicationBuilder AddLogService(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<ILogService, LogSerivce>();
            return builder;
        }
    }
}
