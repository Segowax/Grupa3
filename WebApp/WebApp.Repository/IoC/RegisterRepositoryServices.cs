using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Repository.IoC
{
    public static class RegisterRepositoryServices 
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DBcontextClass>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnString"));
            });

            return services;
        }
    }
}
