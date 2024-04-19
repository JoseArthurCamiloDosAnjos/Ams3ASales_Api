using AMS3ASales.api.Domain;
using Microsoft.EntityFrameworkCore;

namespace AMS3ASales.api.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options): base(options)
        { 
        
        }
        public DbSet<Category> Categoriy { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
