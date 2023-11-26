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
        public User GetByID (string id);
        public User GetByPhone (string name);
        User GetUserByUsername(string username);
        public void Add(User user);
        public void Update(User user);
        public void Delete(string user);
        IEnumerable<User> GetAll();
    }
}
