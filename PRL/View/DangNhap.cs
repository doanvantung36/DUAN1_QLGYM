using BUS.Services;
using DAL.GymInterface;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            userService = new UserService(userRepository);
        }
        private UserRepository userRepository = new UserRepository();
        private UserService userService;
        //Sự kiện được sử dụng để thông báo rằng người dùng đã đăng nhập thành công
        public event Action<User> UserLoggedIn;


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtID.Text;
            string password = txtPassword.Text;


            if (userService.AuthenticateUser(username, password))
            {
                // Lấy thông tin người dùng và gửi sự kiện UserLoggedIn
                var user = userRepository.GetUserByUsername(username);
                UserLoggedIn?.Invoke(user);

                MessageBox.Show("Login successful!");

                // Đóng form đăng nhập
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Invalid credentials.");
            }
        }
    }
}
