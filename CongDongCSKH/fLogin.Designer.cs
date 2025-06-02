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
            this.components = new System.ComponentModel.Container();

            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.btLogin = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btLoginManager = new System.Windows.Forms.Button();

            this.labelNoAccount = new System.Windows.Forms.Label();
            this.linkDangKy = new System.Windows.Forms.LinkLabel();

            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(340, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(139, 32);
            this.labelTitle.Text = "ĐĂNG NHẬP";

            // labelUsername
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(220, 120);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(169, 20);
            this.labelUsername.Text = "Tên đăng nhập hoặc email";

            // txtName
            this.txtName.Location = new System.Drawing.Point(400, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 0;

            // labelPassword
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(220, 170);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.Text = "Mật khẩu";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(400, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 27);
            this.txtPassword.TabIndex = 1;

            // btLogin
            this.btLogin.Location = new System.Drawing.Point(400, 220);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 35);
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.TabIndex = 2;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);

            // btClose
            this.btClose.Location = new System.Drawing.Point(520, 220);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 35);
            this.btClose.Text = "Đóng";
            this.btClose.TabIndex = 3;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);

            // btLoginManager
            this.btLoginManager.Location = new System.Drawing.Point(680, 20);
            this.btLoginManager.Name = "btLoginManager";
            this.btLoginManager.Size = new System.Drawing.Size(90, 30);
            this.btLoginManager.Text = "Quản trị";
            this.btLoginManager.TabIndex = 4;
            this.btLoginManager.UseVisualStyleBackColor = true;
            this.btLoginManager.Click += new System.EventHandler(this.btLoginManager_Click);

            // labelNoAccount
            this.labelNoAccount.AutoSize = true;
            this.labelNoAccount.Location = new System.Drawing.Point(300, 290);
            this.labelNoAccount.Name = "labelNoAccount";
            this.labelNoAccount.Size = new System.Drawing.Size(145, 20);
            this.labelNoAccount.Text = "Chưa có tài khoản?";

            // linkDangKy
            this.linkDangKy.AutoSize = true;
            this.linkDangKy.Location = new System.Drawing.Point(450, 290);
            this.linkDangKy.Name = "linkDangKy";
            this.linkDangKy.Size = new System.Drawing.Size(60, 20);
            this.linkDangKy.TabStop = true;
            this.linkDangKy.Text = "Đăng ký";
            this.linkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangKy_LinkClicked);

            // fLogin
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btLoginManager);
            this.Controls.Add(this.labelNoAccount);
            this.Controls.Add(this.linkDangKy);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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