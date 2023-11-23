using DAL.GymInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class UserService
    {
        private IUser userRepository;

        public UserService(IUser userRepository)
        {
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public bool AuthenticateUser(string username, string password)
        {
            return userRepository.ValidateUserCredentials(username, password);
        }
    }
}
