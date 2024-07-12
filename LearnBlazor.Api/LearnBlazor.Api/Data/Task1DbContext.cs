using LearnBlazor.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnBlazor.Api.Data
{
    public class Task1DbContext : DbContext
    {
        public Task1DbContext(DbContextOptions<Task1DbContext> options) : base(options) {
        
        }

        public DbSet<Task1> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task1>()
                .HasKey(t => t.MHID); // Định nghĩa khóa chính cho lớp Task
        }
    }
}
