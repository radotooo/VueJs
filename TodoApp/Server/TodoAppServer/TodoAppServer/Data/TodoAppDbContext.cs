using Microsoft.EntityFrameworkCore;


namespace TodoAppServer.Data
{
    public class TodoAppDbContext : DbContext
    {
        public DbSet<TaskToDo> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source=ToDoApp.db");


        }
    }
}
