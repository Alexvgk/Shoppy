using Microsoft.EntityFrameworkCore;
using Shoppy.Models;

namespace Shoppy.Data
{
    public class ShoppyDBContext : DbContext
    {

        public ShoppyDBContext( DbContextOptions<ShoppyDBContext> options) : base (options) 
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
