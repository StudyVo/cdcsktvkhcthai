namespace CongDongCSKH
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btLoginManager = new Button();
            btClose = new Button();
            txtName = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            linkDangKy = new LinkLabel();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 148);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 205);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // btLoginManager
            // 
            btLoginManager.Location = new Point(683, 12);
            btLoginManager.Name = "btLoginManager";
            btLoginManager.Size = new Size(94, 29);
            btLoginManager.TabIndex = 3;
            btLoginManager.Text = "Quản trị";
            btLoginManager.UseVisualStyleBackColor = true;
            btLoginManager.Click += btLoginManager_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(423, 292);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 5;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(354, 148);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(354, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 219);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 414);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 9;
            label5.Text = "Chưa có tài khoản?";
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Location = new Point(426, 414);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(60, 20);
            linkDangKy.TabIndex = 10;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đăng kí";
            linkDangKy.LinkClicked += linkDangKy_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(285, 294);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 12;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(linkDangKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(btClose);
            Controls.Add(btLoginManager);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Name = "fLogin";
            Text = "Đăng nhập ";
            WindowState = FormWindowState.Maximized;
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btLoginManager;
        private Button btClose;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private LinkLabel linkDangKy;
        private ToolTip toolTip1;
        private Button button1;
    }
}
