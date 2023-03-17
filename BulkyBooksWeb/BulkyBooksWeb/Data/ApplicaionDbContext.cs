using BulkyBooksWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooksWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> categories { get; set; }


    }
}
