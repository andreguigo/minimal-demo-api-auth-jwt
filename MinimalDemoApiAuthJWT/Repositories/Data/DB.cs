using MinimalDemoApiAuthJWT.Models;

namespace MinimalDemoApiAuthJWT.Repositories.Data
{
    public class DB : DbContext
    {
        protected override void OnConfiiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var strConnect = "server=localhost; database=api_auth_jwt; uid=root; DefaultCommandTimeout=60; Allow User Variables=true";
                options.UseMySql(strConnect, ServerVersion.AutoDetect(strConnect));
            }
        }

        public DbSet<User> User { get; set; }
    }
}