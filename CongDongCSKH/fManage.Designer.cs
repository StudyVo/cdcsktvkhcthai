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
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();

            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.labelHint = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();

            // pictureBoxAvatar
            this.pictureBoxAvatar.Location = new System.Drawing.Point(30, 30);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAvatar.TabStop = false;

            // labelHoTen
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(30, 210);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(55, 20);
            this.labelHoTen.Text = "Họ tên:";

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 240);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 20);
            this.labelEmail.Text = "Email:";

            // labelMoTa
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Location = new System.Drawing.Point(30, 270);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(49, 20);
            this.labelMoTa.Text = "Mô tả:";

            // labelNgaySinh
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(30, 300);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(78, 20);
            this.labelNgaySinh.Text = "Ngày sinh:";

            // btnEditInfo
            this.btnEditInfo.Location = new System.Drawing.Point(30, 330);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(130, 35);
            this.btnEditInfo.Text = "Sửa thông tin";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(30, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 35);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // btnViewCourses
            this.btnViewCourses.Location = new System.Drawing.Point(230, 30);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(180, 35);
            this.btnViewCourses.Text = "Xem tất cả khóa học";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);

            // btnManageUsers
            this.btnManageUsers.Location = new System.Drawing.Point(230, 75);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(180, 35);
            this.btnManageUsers.Text = "Quản lý người dùng";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

            // btnPosts
            this.btnPosts.Location = new System.Drawing.Point(230, 120);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(180, 35);
            this.btnPosts.Text = "Xem bài đăng";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);

            // btnMessage
            this.btnMessage.Location = new System.Drawing.Point(230, 165);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(180, 35);
            this.btnMessage.Text = "Nhắn tin";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);

            // btnChatbot
            this.btnChatbot.Location = new System.Drawing.Point(230, 210);
            this.btnChatbot.Name = "btnChatbot";
            this.btnChatbot.Size = new System.Drawing.Size(180, 35);
            this.btnChatbot.Text = "Chat với AI (Gemini)";
            this.btnChatbot.UseVisualStyleBackColor = true;
            this.btnChatbot.Click += new System.EventHandler(this.btnChatbot_Click);

            // dataGridViewMain
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(230, 270);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.Size = new System.Drawing.Size(1600, 600);
            this.dataGridViewMain.TabIndex = 0;

            // labelHint
            this.labelHint.AutoSize = true;
            this.labelHint.ForeColor = System.Drawing.Color.Red;
            this.labelHint.Location = new System.Drawing.Point(230, 245);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(250, 20);
            this.labelHint.Text = "Chọn các chức năng trên để xem chi tiết";

            // fManage
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 900);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelMoTa);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewCourses);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnPosts);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnChatbot);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.labelHint);
            this.Name = "fManage";
            this.Text = "Quản trị hệ thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}