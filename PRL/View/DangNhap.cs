﻿using BUS.Services;
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
        private readonly UserService _userService;
        public DangNhap(UserService userService, object userService1)
        {
            InitializeComponent();
            _userService = userService;
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (_userService == null)
            {
                // Thông báo hoặc xử lý khi _userService chưa được thiết lập
                MessageBox.Show("UserService chưa được thiết lập");
                return;
            }
            string username = txtID.Text;
            string phone = "";
            string password = txtPassword.Text;

            User user = _userService.UserLogin(username, phone, password);
            if (user != null)
            {
                TrangChu trangChuForm = new TrangChu(user, _userService);
                trangChuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
