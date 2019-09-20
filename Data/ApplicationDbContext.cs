using Challenge_3_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge_3_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<RowData> RowData { get; set; }
        public DbSet<Window> Windows { get; set; }
        
    }
}