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
        public TrangChu()
        {
            InitializeComponent();
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

        private void btn_HoiVien_Click(object sender, EventArgs e)
        {
            OpentChillForm(new QuanLyHoiVien());
            txtChucNang.Text = btn_HoiVien.Text;
        }

        private void btn_PT_Click(object sender, EventArgs e)
        {
            OpentChillForm(new PT());
            txtChucNang.Text = btn_PT.Text;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new DatLich());
            txtChucNang.Text = btnDatLich.Text;
            
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            OpentChillForm(new ThietBi());
            txtChucNang.Text = btnThietBi.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpentChillForm(new NhanVien());
            txtChucNang.Text = btn_HoiVien.Text;
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            OpentChillForm(new KhuyenMai());
            txtChucNang.Text = btnKhuyenMai.Text;
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new GiaoDich());
            txtChucNang.Text = btnGiaoDich.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (curentChillForm != null)
            {
                curentChillForm.Close();
            }
            txtChucNang.Text = "Trang chu";
        }
    }
}
