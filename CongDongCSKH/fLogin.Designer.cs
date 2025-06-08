namespace CongDongCSKH
{
    partial class fLogin
    {
        /// <summary>
        ///  Tài nguyên đang sử dụng
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Giải phóng tài nguyên đang dùng
        /// </summary>
        /// <param name="disposing">true nếu giải phóng thủ công</param>
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
        ///  Thiết lập và cấu hình giao diện form đăng nhập
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            btClose = new Button();
            btLoginManager = new Button();
            labelNoAccount = new Label();
            linkDangKy = new LinkLabel();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(340, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(161, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG NHẬP";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(210, 120);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(184, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Tên đăng nhập hoặc email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(210, 170);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mật khẩu";
            // 
            // txtName
            // 
            txtName.Location = new Point(400, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Lime;
            btLogin.Location = new Point(400, 220);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 35);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Red;
            btClose.Location = new Point(520, 220);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 35);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btLoginManager
            // 
            btLoginManager.BackColor = Color.Yellow;
            btLoginManager.FlatStyle = FlatStyle.Popup;
            btLoginManager.ForeColor = SystemColors.ControlText;
            btLoginManager.Location = new Point(680, 20);
            btLoginManager.Name = "btLoginManager";
            btLoginManager.Size = new Size(90, 30);
            btLoginManager.TabIndex = 4;
            btLoginManager.Text = "Quản trị";
            btLoginManager.UseVisualStyleBackColor = false;
            btLoginManager.Click += btLoginManager_Click;
            // 
            // labelNoAccount
            // 
            labelNoAccount.AutoSize = true;
            labelNoAccount.Location = new Point(300, 290);
            labelNoAccount.Name = "labelNoAccount";
            labelNoAccount.Size = new Size(135, 20);
            labelNoAccount.TabIndex = 5;
            labelNoAccount.Text = "Chưa có tài khoản?";
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Location = new Point(450, 290);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(63, 20);
            linkDangKy.TabIndex = 6;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đăng ký";
            linkDangKy.LinkClicked += linkDangKy_LinkClicked;
            // 
            // fLogin
            // 
            AcceptButton = btLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(txtName);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(btLogin);
            Controls.Add(btClose);
            Controls.Add(btLoginManager);
            Controls.Add(labelNoAccount);
            Controls.Add(linkDangKy);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btLoginManager;

        private System.Windows.Forms.Label labelNoAccount;
        private System.Windows.Forms.LinkLabel linkDangKy;

        private System.Windows.Forms.ToolTip toolTip1;
    }
}