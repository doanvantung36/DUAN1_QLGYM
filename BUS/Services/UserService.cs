using DAL.DBContexs;
using DAL.GymInterface;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly GymDBContext _gymDBContext;
        public UserService(UserRepository userRepository, GymDBContext gymDBContext)
        {
            _userRepository = userRepository;
            _gymDBContext = gymDBContext;
        }
        public User GetID(string id)
        {
            return _userRepository.GetByID(id);
        }
        public User GetPhone(string phone)
        {
            return _userRepository.GetByPhone(phone);
        }
        public void CreateUser(User user)
        {
            // Kiểm tra số điện thoại đã tồn tại chưa
            if (_userRepository.GetByPhone(user.Phone) == null)
            {
                _userRepository.Add(user);
            }
            else
            {
                // Xử lý khi số điện thoại đã tồn tại
            }
        }
        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(string userId)
        {
            _userRepository.Delete(userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User UserLogin(string id, string phone, string password)
        {
            return _gymDBContext.User.SingleOrDefault
                (
                    u => (u.Id == id ||
                    u.Phone == phone) &&
                    u.Password == password
                );

        }

        public bool Rules(User user, string role)
        {
            return user != null && user.Roles == role;
        }
    }
}
