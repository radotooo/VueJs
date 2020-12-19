using Microsoft.EntityFrameworkCore;

namespace TodoAppServer.Data
{
    public class TodoAppDbContext : DbContext
    {
        public DbSet<TaskToDo> Tasks { get; set; }
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options)
       : base(options)
        {
        }

      
    }
}
