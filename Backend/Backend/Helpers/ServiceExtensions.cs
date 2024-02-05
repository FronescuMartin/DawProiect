using Backend.Repositories;
using Backend.Services;

namespace Backend.Helpers
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPersoanaRepository, PersoanaRepository>();
            services.AddTransient<ICompetitieRepository, CompetitieRepository>();
            services.AddTransient<IRezultatRepository, RezultatRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPersoanaService, PersoanaService>();
            services.AddTransient<ICompetitieService, CompetitieService>();
            services.AddTransient<IRezultatService, RezultatService>();

            return services;
        }
    }
}