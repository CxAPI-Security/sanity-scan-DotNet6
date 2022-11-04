using System.Data.Entity;
using ApiDiscovery.Models;

namespace ApiDiscovery.App_Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
    }
}