using MininalApiAuth.Models;

namespace MininalApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User> {
                new User { Id = 1, UserName="frederico", Password="opa123", Role="manager"},
                new User { Id = 2, UserName="pedro", Password ="xi123", Role="employee"}
            };
            return users.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower());
        }
    }
}
