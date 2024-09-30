using AssetManagenetAPI.Data;
using AssetManagenetAPI.Factory;
using AssetManagenetAPI.Repositories;
using AssetManagenetAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace AssetManagenetAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, string conString)
        {
            services.AddDbContext<AssetContext>(opt => 
            {
                opt.UseSqlServer(conString);
            });
            return services;
        }

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services) 
        {
            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services) 
        {
            services.AddScoped<IAssetRepository, AssetRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IAssetService, AssetService>();
            return services;
        }

        public static IServiceCollection AddFactoryConfig(this IServiceCollection services)
        {
            services.AddScoped<IAssetFactory, AssetFactory>();
            return services;
        }
    }
}