using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace WebApp.Service.IoC
{
    public static class RegisterServiceServices
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
