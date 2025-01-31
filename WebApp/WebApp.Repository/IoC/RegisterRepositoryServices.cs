using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Repository.Repositories;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.IoC
{
    public static class RegisterRepositoryServices
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnString"));
            });

            services.AddScoped<ILokaleRepository, LokaleRepository>();
            services.AddScoped<IDaniaRepository,DaniaRepository>();
            services.AddScoped<IPracownicyRepository,PracownicyRepository>();
            services.AddScoped<IRezerwacjeRepository,RezerwacjeRepository>();

            return services;
        }
    }
}
