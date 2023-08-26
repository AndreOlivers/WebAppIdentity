using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace WebAppIdentity.DependecyInjection
{
    public static class ConfigureDatabase
    {
        public static void ConfiguriesDataBaseSqlServer(this IServiceCollection services)
        {
            string connectionString = @"Server=.\\SQLEXPRESS;Database=IdentityStydy;Trusted_Connection=True;";
            services.AddDbContext<IdentityDbContext>(
                options => options.UseSqlServer(connectionString));
        }
    }
}
