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
        private void InitializeControls()
        {
            //// Set the Anchor property for each control
            //panel_Body.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            //txtChucNang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            //// Add controls to the Form
            //Controls.Add(panel_Body);
            //Controls.Add(txtChucNang);
        }
        private readonly User _Logined;
        private readonly UserService _UserService;

        public TrangChu(User loggedInUser, UserService userService)
        {
            InitializeComponent();
            _Logined = loggedInUser;
            _UserService = userService;
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
            if (_UserService.Rules(_Logined, "NhanVien"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này");
            }
            else
            {
                OpentChillForm(new NhanVien());
                txtChucNang.Text = btn_HoiVien.Text;
                SetButtonColor(btnNhanVien);
            }  
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if (_UserService.Rules(_Logined, "NhanVien"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này");
            }
            else
            {
                OpentChillForm(new KhuyenMai());
                txtChucNang.Text = btnKhuyenMai.Text;
                SetButtonColor(btnKhuyenMai);
            }
            
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
            
        }
    }
}
