using Assignment.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Setting> Setting { get; set; }
    }
}
