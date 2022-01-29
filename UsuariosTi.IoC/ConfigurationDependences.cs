using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Corretora.Business.Extensions;
using Corretora.Business.Interfaces;
using Corretora.Business.Interfaces.Services;
using Corretora.Business.Services;
using Corretora.Data.Context;
using Corretora.Data.Repository;

namespace Corretora.IoC
{
    public static class ConfigurationDependences
    {
        public static IServiceCollection AddDependences(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("CorretoraConnection");
            services.AddDbContext<CorretoraContext>(opt => opt.UseSqlServer(connection));

            services.AddScoped<IT002_PERFILRepository, T002_PERFILRepository>();
            services.AddScoped<Idiectvw006_willis_rural_visaoRepository, diectvw006_willis_rural_visaoRepository>();


            services.AddScoped<IT003_PERFIL_USUARIORepository, T003_PERFIL_USUARIORepository>();



            services.AddScoped<IUser, AspNetUser>();

            services.AddScoped<IHomeService, HomeService>();


            return services;
        }
    }
}
