using BUS.Services;
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
    public partial class TrangChu : Form
    {
        private UserRepository userRepository = new UserRepository();
        private UserService userService;
        private void InitializeControls()
        {
            //// Set the Anchor property for each control
            //panel_Body.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            //txtChucNang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            //// Add controls to the Form
            //Controls.Add(panel_Body);
            //Controls.Add(txtChucNang);
        }
        private void HandleUserLoggedIn(User user)
        {
            // Kiểm tra và kích hoạt/vô hiệu hóa nút dựa trên vai trò
            if (user != null && user.Rule.Contains("NhanVien"))
            {
                // Nếu là nhân viên, vô hiệu hóa nút
                btnNhanVien.Enabled = false;
                btnKhuyenMai.Enabled = false;
            }
            else
            {
                // Nếu không phải nhân viên, kích hoạt nút
                btnNhanVien.Enabled = true;
                btnKhuyenMai.Enabled = true;
            }
        }
        public TrangChu()
        {
            InitializeComponent();
            InitializeControls();
            userService = new UserService(userRepository);
        }

        private Form curentChillForm;

        private void OpentChillForm(Form ChillForm)
        {
            if (curentChillForm != null)
            {
                curentChillForm.Close();
            }
            curentChillForm = ChillForm;
            ChillForm.TopLevel = false;
            ChillForm.FormBorderStyle = FormBorderStyle.None;

            ChillForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(curentChillForm);
            panel_Body.Tag = ChillForm;
            ChillForm.BringToFront();
            ChillForm.Show();
        }
        private Button selectedButton;
        private void SetButtonColor(Button button)
        {
            // Reset the color of the previously selected button
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.ControlLight;
            }

            // Set the color of the currently selected button
            button.BackColor = Color.YellowGreen;

            // Update the selectedButton reference
            selectedButton = button;
        }
        private void btn_HoiVien_Click(object sender, EventArgs e)
        {
            OpentChillForm(new QuanLyHoiVien());
            txtChucNang.Text = btn_HoiVien.Text;
            SetButtonColor(btn_HoiVien);
        }

        private void btn_PT_Click(object sender, EventArgs e)
        {
            OpentChillForm(new PT());
            txtChucNang.Text = btn_PT.Text;

            SetButtonColor(btn_PT);
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new DatLich());
            txtChucNang.Text = btnDatLich.Text;
            SetButtonColor(btnDatLich);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            OpentChillForm(new ThietBi());
            txtChucNang.Text = btnThietBi.Text;
            SetButtonColor(btnThietBi);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpentChillForm(new NhanVien());
            txtChucNang.Text = btn_HoiVien.Text;
            SetButtonColor(btnNhanVien);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            OpentChillForm(new KhuyenMai());
            txtChucNang.Text = btnKhuyenMai.Text;
            SetButtonColor(btnKhuyenMai);
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new GiaoDich());
            txtChucNang.Text = btnGiaoDich.Text;
            SetButtonColor(btnGiaoDich);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (curentChillForm != null)
            {
                curentChillForm.Close();
            }
            txtChucNang.Text = "Trang chu";
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // Khởi tạo form đăng nhập và đăng ký sự kiện UserLoggedIn
            DangNhap loginForm = new DangNhap();
            loginForm.UserLoggedIn += HandleUserLoggedIn;

            // Hiển thị form đăng nhập
            loginForm.ShowDialog();
        }
    }
}
