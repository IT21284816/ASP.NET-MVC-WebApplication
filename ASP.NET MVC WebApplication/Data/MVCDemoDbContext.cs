using ASP.NET_MVC_WebApplication.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_WebApplication.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
