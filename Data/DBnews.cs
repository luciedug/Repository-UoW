using Microsoft.EntityFrameworkCore;
using WebApiFinal.Models;
namespace WebApiFinal
{
    public class DBnews : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=New.db");
        }

        public DbSet<New> NewsInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<New>().HasData(
            new New() { ID = 54, Description = "blabla" });
        }
        
       

        
    }

}