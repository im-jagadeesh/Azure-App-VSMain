using Microsoft.EntityFrameworkCore;

namespace Azure_App_VSMain.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
