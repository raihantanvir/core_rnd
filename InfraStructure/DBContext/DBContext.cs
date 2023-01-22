using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace InfraStructure.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Webinar> Webinars { get; set; }
    }
}
