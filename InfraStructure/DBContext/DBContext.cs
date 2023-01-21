using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace InfraStructure.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Webinar> Weninars { get; set; }

    }
}
