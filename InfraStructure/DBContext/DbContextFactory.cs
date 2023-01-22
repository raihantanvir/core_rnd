using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InfraStructure.DBContext
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private static AppDbContext? _context = null;
        public AppDbContext CreateDbContext(string[] args)
        {
            if (_context == null)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                var builder = new DbContextOptionsBuilder<AppDbContext>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                builder.UseSqlServer(connectionString);
                _context = new AppDbContext(builder.Options);
            }

            return _context;
        }
    }
}