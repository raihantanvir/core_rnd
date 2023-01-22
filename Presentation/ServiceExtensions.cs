using Application;
using InfraStructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class ServiceExtensions
    {
        public static void AddServiceLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddAppDBContext(connectionString!);
            services.AddApplicationServices();
            services.AddInfrastructureServices();
        }
    }
}
