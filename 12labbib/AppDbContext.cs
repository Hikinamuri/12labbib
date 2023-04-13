using Microsoft.EntityFrameworkCore;

namespace _12labbib
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "" +
            "Data Source=(localdb)\\mssqllocaldb;" +
            "Initial Catalog=LibraryDb2;" +
            "Integrated Security=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<Sales> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public void EnsureDatabaseCreated()
        {
            // Create the database and tables if they don't exist
            Database.EnsureCreated();
        }
    }
}