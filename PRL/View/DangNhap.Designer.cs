namespace PRL.View
{
    partial class DangNhap
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 110);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "ID đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 178);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Passwword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(266, 42);
            label3.Name = "label3";
            label3.Size = new Size(300, 41);
            label3.TabIndex = 4;
            label3.Text = "WOLRGYM FITNESS";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(359, 229);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // button1
            // 
            button1.Location = new Point(266, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(463, 252);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 364);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
    }
}