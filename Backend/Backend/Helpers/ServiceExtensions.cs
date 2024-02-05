using Backend.Repositories;
using Backend.Services;

namespace Backend.Helpers
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPersoanaRepository, PersoanaRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPersoanaService, PersoanaService>();

            return services;
        }
    }
}