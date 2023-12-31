using MinimalDemoApiAuthJWT.Models;
using MinimalDemoApiAuthJWT.Repositories.Data;

namespace MinimalDemoApiAuthJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var conn = new DB();
            return conn.User.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
