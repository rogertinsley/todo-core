using Microsoft.EntityFrameworkCore;

namespace MyToDo.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { }
        
        public DbSet<Todo> Blogs { get; set; }
        public DbSet<Todo> Posts { get; set; }
    }
}
