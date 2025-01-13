using Microsoft.EntityFrameworkCore;
using TaskList.Models;

namespace TaskList.Context
{
    public class ApiContext : DbContext 
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) 
        {

        }

        public DbSet<Models.Task> Tasks { get; set; }
    }
}
