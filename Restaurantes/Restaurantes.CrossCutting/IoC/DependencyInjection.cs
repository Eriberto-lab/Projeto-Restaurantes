using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurantes.Application.Interfaces;
using Restaurantes.Application.Mappings;
using Restaurantes.Application.Services;
using Restaurantes.Domain.Interfaces;
using Restaurantes.Infrastructure.Context;
using Restaurantes.Infrastructure.Repositories;

namespace Restaurantes.CrossCutting.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddScoped<IRestauranteRepository, RestauranteRepository>();
            services.AddScoped<IRestauranteService, RestauranteService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}