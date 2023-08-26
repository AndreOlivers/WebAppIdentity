using WebAppIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebAppIdentity.DependecyInjection
{
    public static class ConfigureIdentityServices
    {
        public static void ConfigureDependeciesIdentity(this IServiceCollection services)
        {
            //services.AddIdentityCore<User>(options => { });
            //services.AddScoped<IUserStore<User>, UserStore>();

            services.AddIdentityCore<IdentityUser>(options => { });
            services.AddScoped<IUserStore<IdentityUser>,
                UserOnlyStore<IdentityUser, IdentityDbContext>>();

            services.AddAuthentication("cookies")
                .AddCookie("cookies", options => options.LoginPath = "/Home/Login");
        }
    }
}
