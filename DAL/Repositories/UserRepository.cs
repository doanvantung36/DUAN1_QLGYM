using DAL.DBContexs;
using DAL.GymInterface;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUser
    {
        private readonly GymDBContext _gymDBContext;
        public UserRepository(GymDBContext gymDBContext)
        {
            _gymDBContext = gymDBContext;
        }
        public User GetByID(string id)
        {
            return _gymDBContext.User.Find(id);
        }
        public User GetByPhone(string phone)
        {
            return _gymDBContext.User.SingleOrDefault(u => u.Phone == phone);
        }
        public User GetUserByUsername(string username)
        {
            return _gymDBContext.User.SingleOrDefault(u => u.Id == username);
        }

        public IEnumerable<User> GetAll() 
        { 
            return _gymDBContext.User.ToList();
        }

        public void Delete(string user)
        {
            var users = _gymDBContext.User.Find(user);
            if(users != null)
            {
                _gymDBContext.Remove(user);
                _gymDBContext.SaveChanges();
            }
        }
        public void Update(User user)
        {
            _gymDBContext.Entry(user).State = EntityState.Modified;
            _gymDBContext.SaveChanges();
        }
        public void Add(User user)
        {
            _gymDBContext.User.Add(user);
            _gymDBContext.SaveChanges();
        }
    }
}
