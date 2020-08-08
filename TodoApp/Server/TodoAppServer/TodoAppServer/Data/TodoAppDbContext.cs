using Microsoft.EntityFrameworkCore;


namespace TodoAppServer.Data
{
    public class TodoAppDbContext : DbContext
    {
        public DbSet<TaskToDo> Tasks { get; set; }
        public TodoAppDbContext()
        {

        }

        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            //.UseSqlite(@"Data Source=ToDoApp.db");


        }
    }
}
