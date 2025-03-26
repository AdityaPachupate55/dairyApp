using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyDairyApp.Models;

namespace MyDairyApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DairyEntry> DairyEntries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TrainingDB;Integrated Security=True;TrustServerCertificate=true");
        }

        #region Seeding Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DairyEntry>().HasData(
                new DairyEntry { Id = 1, Title = "Entry 1", Content = "Content for entry 1", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 2, Title = "Entry 2", Content = "Content for entry 2", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 3, Title = "Entry 3", Content = "Content for entry 3", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 4, Title = "Entry 4", Content = "Content for entry 4", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 5, Title = "Entry 5", Content = "Content for entry 5", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 6, Title = "Entry 6", Content = "Content for entry 6", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 7, Title = "Entry 7", Content = "Content for entry 7", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 8, Title = "Entry 8", Content = "Content for entry 8", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 9, Title = "Entry 9", Content = "Content for entry 9", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 10, Title = "Entry 10", Content = "Content for entry 10", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 11, Title = "Entry 11", Content = "Content for entry 11", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 12, Title = "Entry 12", Content = "Content for entry 12", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 13, Title = "Entry 13", Content = "Content for entry 13", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 14, Title = "Entry 14", Content = "Content for entry 14", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 15, Title = "Entry 15", Content = "Content for entry 15", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 16, Title = "Entry 16", Content = "Content for entry 16", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 17, Title = "Entry 17", Content = "Content for entry 17", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 18, Title = "Entry 18", Content = "Content for entry 18", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 19, Title = "Entry 19", Content = "Content for entry 19", Created = new DateTime(2025, 3, 18) },
                new DairyEntry { Id = 20, Title = "Entry 20", Content = "Content for entry 20", Created = new DateTime(2025, 3, 18) }
            );
        }
        #endregion
    }
}