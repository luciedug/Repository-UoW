using Microsoft.EntityFrameworkCore;

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
            new New() { ID = 1, Description = "blabla" });
        }

        public New GetById(int id)
        {
            foreach (var news in NewsInfo)
            {
                if (news.ID == id)
                    return news;
            }
            return null;
        }

        
    }

}