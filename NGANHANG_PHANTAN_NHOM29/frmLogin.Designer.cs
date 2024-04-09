namespace NGANHANG_PHANTAN_NHOM29
{
    partial class frmLogin
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
            this.LG_groupbox = new System.Windows.Forms.GroupBox();
            this.LG_textboxMatKhau = new System.Windows.Forms.TextBox();
            this.LG_textboxTaiKhoan = new System.Windows.Forms.TextBox();
            this.LG_comboxChiNhanh = new System.Windows.Forms.ComboBox();
            this.LG_labelMatKhau = new System.Windows.Forms.Label();
            this.LG_labelTaiKhoan = new System.Windows.Forms.Label();
            this.LG_labelChiNhanh = new System.Windows.Forms.Label();
            this.LG_buttonDangNhap = new System.Windows.Forms.Button();
            this.LG_buttonThoat = new System.Windows.Forms.Button();
            this.LG_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LG_groupbox
            // 
            this.LG_groupbox.Controls.Add(this.LG_textboxMatKhau);
            this.LG_groupbox.Controls.Add(this.LG_textboxTaiKhoan);
            this.LG_groupbox.Controls.Add(this.LG_comboxChiNhanh);
            this.LG_groupbox.Controls.Add(this.LG_labelMatKhau);
            this.LG_groupbox.Controls.Add(this.LG_labelTaiKhoan);
            this.LG_groupbox.Controls.Add(this.LG_labelChiNhanh);
            this.LG_groupbox.Location = new System.Drawing.Point(56, 32);
            this.LG_groupbox.Name = "LG_groupbox";
            this.LG_groupbox.Size = new System.Drawing.Size(565, 272);
            this.LG_groupbox.TabIndex = 0;
            this.LG_groupbox.TabStop = false;
            // 
            // LG_textboxMatKhau
            // 
            this.LG_textboxMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_textboxMatKhau.Location = new System.Drawing.Point(211, 188);
            this.LG_textboxMatKhau.Name = "LG_textboxMatKhau";
            this.LG_textboxMatKhau.Size = new System.Drawing.Size(317, 30);
            this.LG_textboxMatKhau.TabIndex = 5;
            this.LG_textboxMatKhau.Text = "100303";
            this.LG_textboxMatKhau.UseSystemPasswordChar = true;
            // 
            // LG_textboxTaiKhoan
            // 
            this.LG_textboxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_textboxTaiKhoan.Location = new System.Drawing.Point(211, 105);
            this.LG_textboxTaiKhoan.Name = "LG_textboxTaiKhoan";
            this.LG_textboxTaiKhoan.Size = new System.Drawing.Size(317, 30);
            this.LG_textboxTaiKhoan.TabIndex = 4;
            this.LG_textboxTaiKhoan.Text = "TMN";
            // 
            // LG_comboxChiNhanh
            // 
            this.LG_comboxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LG_comboxChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_comboxChiNhanh.FormattingEnabled = true;
            this.LG_comboxChiNhanh.Location = new System.Drawing.Point(211, 19);
            this.LG_comboxChiNhanh.Name = "LG_comboxChiNhanh";
            this.LG_comboxChiNhanh.Size = new System.Drawing.Size(317, 31);
            this.LG_comboxChiNhanh.TabIndex = 3;
            this.LG_comboxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LG_labelMatKhau
            // 
            this.LG_labelMatKhau.AutoSize = true;
            this.LG_labelMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_labelMatKhau.Location = new System.Drawing.Point(69, 191);
            this.LG_labelMatKhau.Name = "LG_labelMatKhau";
            this.LG_labelMatKhau.Size = new System.Drawing.Size(106, 23);
            this.LG_labelMatKhau.TabIndex = 2;
            this.LG_labelMatKhau.Text = "Mật Khẩu :";
            // 
            // LG_labelTaiKhoan
            // 
            this.LG_labelTaiKhoan.AutoSize = true;
            this.LG_labelTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_labelTaiKhoan.Location = new System.Drawing.Point(57, 108);
            this.LG_labelTaiKhoan.Name = "LG_labelTaiKhoan";
            this.LG_labelTaiKhoan.Size = new System.Drawing.Size(109, 23);
            this.LG_labelTaiKhoan.TabIndex = 1;
            this.LG_labelTaiKhoan.Text = "Tài Khoản :";
            // 
            // LG_labelChiNhanh
            // 
            this.LG_labelChiNhanh.AutoSize = true;
            this.LG_labelChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_labelChiNhanh.Location = new System.Drawing.Point(56, 22);
            this.LG_labelChiNhanh.Name = "LG_labelChiNhanh";
            this.LG_labelChiNhanh.Size = new System.Drawing.Size(110, 23);
            this.LG_labelChiNhanh.TabIndex = 0;
            this.LG_labelChiNhanh.Text = "Chi Nhánh :";
            // 
            // LG_buttonDangNhap
            // 
            this.LG_buttonDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_buttonDangNhap.Location = new System.Drawing.Point(139, 361);
            this.LG_buttonDangNhap.Name = "LG_buttonDangNhap";
            this.LG_buttonDangNhap.Size = new System.Drawing.Size(157, 40);
            this.LG_buttonDangNhap.TabIndex = 1;
            this.LG_buttonDangNhap.Text = "Đăng Nhập";
            this.LG_buttonDangNhap.UseVisualStyleBackColor = true;
            this.LG_buttonDangNhap.Click += new System.EventHandler(this.LG_buttonDangNhap_Click);
            // 
            // LG_buttonThoat
            // 
            this.LG_buttonThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LG_buttonThoat.Location = new System.Drawing.Point(451, 361);
            this.LG_buttonThoat.Name = "LG_buttonThoat";
            this.LG_buttonThoat.Size = new System.Drawing.Size(120, 40);
            this.LG_buttonThoat.TabIndex = 2;
            this.LG_buttonThoat.Text = "Thoát";
            this.LG_buttonThoat.UseVisualStyleBackColor = true;
            this.LG_buttonThoat.Click += new System.EventHandler(this.LG_buttonThoat_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(685, 446);
            this.Controls.Add(this.LG_buttonThoat);
            this.Controls.Add(this.LG_buttonDangNhap);
            this.Controls.Add(this.LG_groupbox);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.LG_groupbox.ResumeLayout(false);
            this.LG_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LG_groupbox;
        private System.Windows.Forms.TextBox LG_textboxMatKhau;
        private System.Windows.Forms.TextBox LG_textboxTaiKhoan;
        private System.Windows.Forms.ComboBox LG_comboxChiNhanh;
        private System.Windows.Forms.Label LG_labelMatKhau;
        private System.Windows.Forms.Label LG_labelTaiKhoan;
        private System.Windows.Forms.Label LG_labelChiNhanh;
        private System.Windows.Forms.Button LG_buttonDangNhap;
        private System.Windows.Forms.Button LG_buttonThoat;
    }
}