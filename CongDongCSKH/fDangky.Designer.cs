namespace CongDongCSKH
{
    partial class fDangky
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Giải phóng tài nguyên đang được sử dụng
        /// </summary>
        /// <param name="disposing">true nếu muốn giải phóng tài nguyên</param>
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
        ///  Thiết lập giao diện và khởi tạo các control
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelTenDn = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTenDn = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(280, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ĐĂNG KÝ";

            // labelHoTen
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(130, 70);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(74, 20);
            this.labelHoTen.TabIndex = 1;
            this.labelHoTen.Text = "Họ và tên";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(280, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 27);
            this.txtHoTen.TabIndex = 0;

            // labelTenDn
            this.labelTenDn.AutoSize = true;
            this.labelTenDn.Location = new System.Drawing.Point(130, 110);
            this.labelTenDn.Name = "labelTenDn";
            this.labelTenDn.Size = new System.Drawing.Size(107, 20);
            this.labelTenDn.TabIndex = 2;
            this.labelTenDn.Text = "Tên đăng nhập";

            // txtTenDn
            this.txtTenDn.Location = new System.Drawing.Point(280, 107);
            this.txtTenDn.Name = "txtTenDn";
            this.txtTenDn.Size = new System.Drawing.Size(250, 27);
            this.txtTenDn.TabIndex = 1;

            // labelPassword
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(130, 150);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mật khẩu";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(280, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 27);
            this.txtPassword.TabIndex = 2;

            // labelConfirmPassword
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(130, 190);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(130, 20);
            this.labelConfirmPassword.TabIndex = 4;
            this.labelConfirmPassword.Text = "Nhập lại mật khẩu";

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new System.Drawing.Point(280, 187);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 27);
            this.txtConfirmPassword.TabIndex = 3;

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(130, 230);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(280, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 4;

            // labelNgaySinh
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(130, 270);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(74, 20);
            this.labelNgaySinh.TabIndex = 6;
            this.labelNgaySinh.Text = "Ngày sinh";

            // ngaysinh
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.ngaysinh.Location = new System.Drawing.Point(280, 267);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(250, 27);
            this.ngaysinh.TabIndex = 5;

            // btSave
            this.btSave.Location = new System.Drawing.Point(280, 320);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 35);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Đăng ký";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);

            // btClose
            this.btClose.Location = new System.Drawing.Point(430, 320);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 35);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);

            // fDangky
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTenDn);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTenDn);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.labelTitle);

            this.Name = "fDangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelTenDn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNgaySinh;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTenDn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
