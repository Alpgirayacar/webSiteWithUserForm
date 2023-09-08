using Microsoft.EntityFrameworkCore;
using webSiteWithUserForm.Models;

namespace webSiteWithUserForm
{
    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
        {


        }

        public DbSet<Visiter> VisitersList { get; set; }
    }
}
