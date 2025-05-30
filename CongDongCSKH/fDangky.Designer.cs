namespace CongDongCSKH
{
    partial class fDangky
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btSave = new Button();
            btClose = new Button();
            ngaysinh = new DateTimePicker();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            txtConfirmPassword = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 43);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 118);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 315);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 490);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 4;
            label5.Text = "Đã có tài khoản";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(395, 490);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            // 
            // txtName
            // 
            txtName.Location = new Point(346, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 27);
            txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(346, 308);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 27);
            txtEmail.TabIndex = 3;
            // 
            // btSave
            // 
            btSave.Location = new Point(258, 396);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 4;
            btSave.Text = "Đăng ký";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(383, 396);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 5;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // ngaysinh
            // 
            ngaysinh.CustomFormat = "hh/MM/yyyy";
            ngaysinh.Format = DateTimePickerFormat.Custom;
            ngaysinh.Location = new Point(346, 257);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(188, 27);
            ngaysinh.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 257);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày sinh";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(346, 208);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(188, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 211);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 14;
            label7.Text = "Nhập lại mật khẩu";
            // 
            // fDangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 519);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(ngaysinh);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fDangky";
            Text = "Tạo tài khoản ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btSave;
        private Button btClose;
        private DateTimePicker ngaysinh;
        private Label label6;
        private ToolTip toolTip1;
        private TextBox txtConfirmPassword;
        private Label label7;
    }
}