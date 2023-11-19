namespace PRL.View
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel_Menu = new Panel();
            btnDangXuat = new Button();
            btnGiaoDich = new Button();
            btnKhuyenMai = new Button();
            btnNhanVien = new Button();
            btnThietBi = new Button();
            btnDatLich = new Button();
            btn_PT = new Button();
            btn_HoiVien = new Button();
            pictureBox1 = new PictureBox();
            PanelControl = new Panel();
            label3 = new Label();
            txtChucNang = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_Body = new Panel();
            panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.Controls.Add(btnDangXuat);
            panel_Menu.Controls.Add(btnGiaoDich);
            panel_Menu.Controls.Add(btnKhuyenMai);
            panel_Menu.Controls.Add(btnNhanVien);
            panel_Menu.Controls.Add(btnThietBi);
            panel_Menu.Controls.Add(btnDatLich);
            panel_Menu.Controls.Add(btn_PT);
            panel_Menu.Controls.Add(btn_HoiVien);
            panel_Menu.Controls.Add(pictureBox1);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(159, 591);
            panel_Menu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.None;
            btnDangXuat.AutoSize = true;
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.ForeColor = SystemColors.ControlLightLight;
            btnDangXuat.Location = new Point(3, 565);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 25);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnGiaoDich
            // 
            btnGiaoDich.BackColor = Color.LightBlue;
            btnGiaoDich.Location = new Point(3, 319);
            btnGiaoDich.Name = "btnGiaoDich";
            btnGiaoDich.Size = new Size(150, 23);
            btnGiaoDich.TabIndex = 7;
            btnGiaoDich.Text = "Quản lý giao dịch";
            btnGiaoDich.UseVisualStyleBackColor = false;
            btnGiaoDich.Click += btnGiaoDich_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.BackColor = Color.LightBlue;
            btnKhuyenMai.Location = new Point(3, 290);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Size = new Size(150, 23);
            btnKhuyenMai.TabIndex = 6;
            btnKhuyenMai.Text = "Quản lý khuyến mại";
            btnKhuyenMai.UseVisualStyleBackColor = false;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.LightBlue;
            btnNhanVien.Location = new Point(3, 261);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(150, 23);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.BackColor = Color.LightBlue;
            btnThietBi.Location = new Point(3, 232);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(150, 23);
            btnThietBi.TabIndex = 4;
            btnThietBi.Text = "Quản  lý thiết bị";
            btnThietBi.UseVisualStyleBackColor = false;
            btnThietBi.Click += btnThietBi_Click;
            // 
            // btnDatLich
            // 
            btnDatLich.BackColor = Color.LightBlue;
            btnDatLich.Location = new Point(3, 203);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(150, 23);
            btnDatLich.TabIndex = 3;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = false;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // btn_PT
            // 
            btn_PT.BackColor = Color.LightBlue;
            btn_PT.Location = new Point(3, 174);
            btn_PT.Name = "btn_PT";
            btn_PT.Size = new Size(150, 23);
            btn_PT.TabIndex = 2;
            btn_PT.Text = "PT";
            btn_PT.UseVisualStyleBackColor = false;
            btn_PT.Click += btn_PT_Click;
            // 
            // btn_HoiVien
            // 
            btn_HoiVien.BackColor = Color.LightBlue;
            btn_HoiVien.Location = new Point(3, 145);
            btn_HoiVien.Name = "btn_HoiVien";
            btn_HoiVien.Size = new Size(150, 23);
            btn_HoiVien.TabIndex = 1;
            btn_HoiVien.Text = "Quản lý hội viên";
            btn_HoiVien.UseVisualStyleBackColor = false;
            btn_HoiVien.Click += btn_HoiVien_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 139);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelControl
            // 
            PanelControl.AutoSize = true;
            PanelControl.BackColor = Color.LavenderBlush;
            PanelControl.Controls.Add(label3);
            PanelControl.Controls.Add(txtChucNang);
            PanelControl.Controls.Add(label2);
            PanelControl.Controls.Add(label1);
            PanelControl.Dock = DockStyle.Top;
            PanelControl.Location = new Point(159, 0);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(953, 47);
            PanelControl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(318, 9);
            label3.Name = "label3";
            label3.Size = new Size(234, 32);
            label3.TabIndex = 3;
            label3.Text = "WOLFGYM FITNESS";
            // 
            // txtChucNang
            // 
            txtChucNang.AutoSize = true;
            txtChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtChucNang.ForeColor = Color.Red;
            txtChucNang.Location = new Point(3, 26);
            txtChucNang.Name = "txtChucNang";
            txtChucNang.Size = new Size(92, 21);
            txtChucNang.TabIndex = 2;
            txtChucNang.Text = "Chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(772, 31);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(772, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng";
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Ivory;
            panel_Body.BackgroundImage = (Image)resources.GetObject("panel_Body.BackgroundImage");
            panel_Body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(159, 47);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(953, 544);
            panel_Body.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1112, 591);
            Controls.Add(panel_Body);
            Controls.Add(PanelControl);
            Controls.Add(panel_Menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            panel_Menu.ResumeLayout(false);
            panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelControl.ResumeLayout(false);
            PanelControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Menu;
        private Button btnDangXuat;
        private Button btnGiaoDich;
        private Button btnKhuyenMai;
        private Button btnNhanVien;
        private Button btnThietBi;
        private Button btnDatLich;
        private Button btn_PT;
        private Button btn_HoiVien;
        private PictureBox pictureBox1;
        private Panel PanelControl;
        private Label txtChucNang;
        private Label label2;
        private Label label1;
        private Panel panel_Body;
        private Label label3;


    }
}