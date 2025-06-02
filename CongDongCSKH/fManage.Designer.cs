namespace CongDongCSKH
{
    partial class fManage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBoxAvatar = new PictureBox();
            labelHoTen = new Label();
            labelEmail = new Label();
            labelMoTa = new Label();
            labelNgaySinh = new Label();
            btnEditInfo = new Button();
            btnLogout = new Button();
            btnViewCourses = new Button();
            btnManageUsers = new Button();
            btnPosts = new Button();
            btnMessage = new Button();
            btnChatbot = new Button();
            dataGridViewMain = new DataGridView();
            labelHint = new Label();
            btXemDanhSachNguoiDung = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(30, 30);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(160, 160);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(30, 210);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(57, 20);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(30, 240);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelMoTa
            // 
            labelMoTa.AutoSize = true;
            labelMoTa.Location = new Point(30, 270);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(51, 20);
            labelMoTa.TabIndex = 3;
            labelMoTa.Text = "Mô tả:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(30, 300);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(77, 20);
            labelNgaySinh.TabIndex = 4;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // btnEditInfo
            // 
            btnEditInfo.Location = new Point(30, 330);
            btnEditInfo.Name = "btnEditInfo";
            btnEditInfo.Size = new Size(130, 35);
            btnEditInfo.TabIndex = 5;
            btnEditInfo.Text = "Sửa thông tin";
            btnEditInfo.UseVisualStyleBackColor = true;
            btnEditInfo.Click += btnEditInfo_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(30, 380);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewCourses
            // 
            btnViewCourses.Location = new Point(230, 30);
            btnViewCourses.Name = "btnViewCourses";
            btnViewCourses.Size = new Size(180, 35);
            btnViewCourses.TabIndex = 7;
            btnViewCourses.Text = "Xem tất cả khóa học";
            btnViewCourses.UseVisualStyleBackColor = true;
            btnViewCourses.Click += btnViewCourses_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(230, 75);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(180, 35);
            btnManageUsers.TabIndex = 8;
            btnManageUsers.Text = "Quản lý người dùng";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnPosts
            // 
            btnPosts.Location = new Point(6, 1);
            btnPosts.Name = "btnPosts";
            btnPosts.Size = new Size(75, 23);
            btnPosts.TabIndex = 9;
            // 
            // btnMessage
            // 
            btnMessage.Location = new Point(230, 165);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(180, 35);
            btnMessage.TabIndex = 10;
            btnMessage.Text = "Nhắn tin";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnChatbot
            // 
            btnChatbot.Location = new Point(230, 210);
            btnChatbot.Name = "btnChatbot";
            btnChatbot.Size = new Size(180, 35);
            btnChatbot.TabIndex = 11;
            btnChatbot.Text = "Chat với AI (Gemini)";
            btnChatbot.UseVisualStyleBackColor = true;
            btnChatbot.Click += btnChatbot_Click;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(230, 270);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.Size = new Size(1785, 600);
            dataGridViewMain.TabIndex = 0;
            dataGridViewMain.CellContentClick += dataGridViewMain_CellContentClick;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.ForeColor = Color.Red;
            labelHint.Location = new Point(230, 245);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(273, 20);
            labelHint.TabIndex = 12;
            labelHint.Text = "Chọn các chức năng trên để xem chi tiết";
            // 
            // btXemDanhSachNguoiDung
            // 
            btXemDanhSachNguoiDung.Location = new Point(230, 125);
            btXemDanhSachNguoiDung.Name = "btXemDanhSachNguoiDung";
            btXemDanhSachNguoiDung.Size = new Size(180, 29);
            btXemDanhSachNguoiDung.TabIndex = 13;
            btXemDanhSachNguoiDung.Text = "Xem tất cả bài đăng";
            btXemDanhSachNguoiDung.UseVisualStyleBackColor = true;
            btXemDanhSachNguoiDung.Click += btXemDanhSachNguoiDung_Click;
            // 
            // fManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 900);
            Controls.Add(btXemDanhSachNguoiDung);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(labelHoTen);
            Controls.Add(labelEmail);
            Controls.Add(labelMoTa);
            Controls.Add(labelNgaySinh);
            Controls.Add(btnEditInfo);
            Controls.Add(btnLogout);
            Controls.Add(btnViewCourses);
            Controls.Add(btnManageUsers);
            Controls.Add(btnPosts);
            Controls.Add(btnMessage);
            Controls.Add(btnChatbot);
            Controls.Add(dataGridViewMain);
            Controls.Add(labelHint);
            Name = "fManage";
            Text = "Quản trị hệ thống";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnChatbot;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label labelHint;
        private Button btXemDanhSachNguoiDung;
    }
}