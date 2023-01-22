using Application.Interfaces;
using InfraStructure.DBContext;
using InfraStructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InfraStructure
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IWebinarRepository), typeof(WebinarRepository));
        }

        public static void AddAppDBContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));        
        }
    }
}
