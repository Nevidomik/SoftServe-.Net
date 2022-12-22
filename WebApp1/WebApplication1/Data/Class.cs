using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbTasks : DbContext
    {
        public DbTasks(DbContextOptions options) : base(options) { }

        public DbSet<Tasks> Tasks { get; set; }
    }

    public class WorkWithDbTasks
    {

    }

}
