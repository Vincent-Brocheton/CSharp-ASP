using Contrat;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using ServiceLogging;

namespace projetApiAsp.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceLogging(this IServiceCollection services) => services.AddScoped<Iloggable, Logger>();

        public static void ConfigureContextSql(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepoContext>(opts => opts.UseSqlServer(config.GetConnectionString("sqlConn"), opts => opts.MigrationsAssembly("projetApiAsp")));
        }

        public static void ConfigureGestionRepos(this IServiceCollection services) => services.AddScoped<IGestionRepo, GestionRepos>();

    }
}
