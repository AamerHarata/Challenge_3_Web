using Challenge_3_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge_3_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        private DbSet<RowData> RowData { get; set; }
        
    }
}