using Microsoft.EntityFrameworkCore;

namespace Sqlite_CRUD
{
    public class DataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = UserData.db");

        }


        public DbSet<User> Users { get; set; }

    }
}
