namespace CongDongCSKH
{
    partial class fLoginManager
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
        ///  Thiết lập giao diện và khởi tạo các điều khiển
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(213, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(347, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG NHẬP QUẢN TRỊ VIÊN";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(180, 110);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(184, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Tên đăng nhập hoặc email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(180, 160);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mật khẩu";
            // 
            // txtName
            // 
            txtName.Location = new Point(370, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(370, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Lime;
            btSave.Location = new Point(370, 210);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 35);
            btSave.TabIndex = 2;
            btSave.Text = "Đăng nhập";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Red;
            btClose.Location = new Point(490, 210);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 35);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // fLoginManager
            // 
            AcceptButton = btSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(txtName);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(btSave);
            Controls.Add(btClose);
            Name = "fLoginManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập quản trị";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;

        private System.Windows.Forms.ToolTip toolTip1;
    }
}
