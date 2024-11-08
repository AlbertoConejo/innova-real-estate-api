using Microsoft.EntityFrameworkCore;
using InnovaRealEstateAPI.Models;

namespace InnovaRealEstateAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
