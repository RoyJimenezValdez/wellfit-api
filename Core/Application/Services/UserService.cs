using wellfit_api.Models;
using wellfit_api.Interfaces;

namespace wellfit_api.Services
{
    public class UserService : IUserService
    {
        public User CreateUser(User user)
        {
            // add to the database 
            return user;
        }
    }

}