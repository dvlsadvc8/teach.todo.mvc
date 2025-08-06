using Microsoft.EntityFrameworkCore;
using teach.todo.mvc.Models;

namespace teach.todo.mvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    }
}
