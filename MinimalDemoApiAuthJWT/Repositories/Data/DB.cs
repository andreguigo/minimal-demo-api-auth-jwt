using Microsoft.EntityFrameworkCore;
using MinimalDemoApiAuthJWT.Models;

namespace MinimalDemoApiAuthJWT.Repositories.Data
{
    public class DB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var connectionStr = "server=localhost; database=api_auth_jwt; uid=root; password=password; DefaultCommandTimeout=60; Allow User Variables=true";              
                options.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr));
            }
        }

        public DbSet<User> User { get; set; }
    }
}