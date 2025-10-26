using BugStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Configs
{
    public static class DbContextConfiguration
    {
        public static WebApplicationBuilder AddDbContextConfiguration(this WebApplicationBuilder builder)
        {
            var _connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(_connectionString));

            return builder;
        }
    }
}
