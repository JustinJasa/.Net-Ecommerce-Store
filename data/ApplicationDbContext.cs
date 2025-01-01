using Microsoft.EntityFrameworkCore;
using ecom_store.Models;
using Microsoft.Identity.Client;

namespace MyMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet<T> properties for each entity model you have
        public DbSet<Product> Products { get; set; }
    }
}
