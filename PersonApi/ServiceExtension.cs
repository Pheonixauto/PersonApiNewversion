using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PersonApi.Datas;
using PersonApi.Models;

namespace PersonApi
{
    public static class ServiceExtension
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<ApiUser>(q=>q.User.RequireUniqueEmail=true);
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }
      
    }
}
