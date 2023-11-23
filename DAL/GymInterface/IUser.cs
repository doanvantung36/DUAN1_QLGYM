using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GymInterface
{
    public interface IUser
    {
        User GetUserByUsername(string username);
        bool ValidateUserCredentials(string username, string password);
    }
}
