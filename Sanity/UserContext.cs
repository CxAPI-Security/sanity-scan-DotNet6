using Microsoft.EntityFrameworkCore;

namespace Sanity
{
    public class UserContext : DbContext
    {
        private readonly IConfiguration _configuration;

        protected UserContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public UserContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("User"));
        }
    }
}