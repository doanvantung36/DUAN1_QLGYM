using DAL.GymInterface;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUser
    {
        public User GetUserByUsername(string username)
        {
            // Triển khai để lấy người dùng theo tên người dùng từ kho dữ liệu
            return null; // Thay thế bằng triển khai thực tế
        }

        public bool ValidateUserCredentials(string username, string password)
        {
            User user = GetUserByUsername(username);

            // Kiểm tra xem người dùng có tồn tại và mật khẩu cung cấp khớp không
            return user != null && user.Password == password;
        }
    }
}
