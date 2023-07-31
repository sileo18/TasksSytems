using Microsoft.EntityFrameworkCore;
using TasksSytems.Data.Map;
using TasksSytems.Models;

namespace TasksSytems.Data
{
    public class TasksSystemsDBContext: DbContext
    {
        public TasksSystemsDBContext(DbContextOptions<TasksSystemsDBContext> options) 
            : base(options)
        {
        }
        public DbSet<UserModel> Users { get; set;}
        public DbSet<TaskModel> Tasks { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
