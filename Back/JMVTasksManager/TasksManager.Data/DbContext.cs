using Microsoft.EntityFrameworkCore;
using TasksManager.Data.Configurations;
using TasksManager.Data.Entities;

namespace TasksManager.Data
{
    public class TasksManagerContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }

        public TasksManagerContext(DbContextOptions<TasksManagerContext> options) :
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfiguration(new TasksItemEntityConfiguration());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
