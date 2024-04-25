using Microsoft.EntityFrameworkCore;

 namespace StartiumWebApi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<SignUpModel> SignUpDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=StartiumDB;Integrated Security=true");
            }
        }
    }
}
