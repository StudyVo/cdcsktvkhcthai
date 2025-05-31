// fEditUser.Designer.cs
namespace CongDongCSKH
{
    partial class fEditUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxMoTa;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label labelHoTen, labelGioiTinh, labelNgaySinh, labelEmail, labelPhone, labelAddress, labelMoTa;
        private System.Windows.Forms.Label labelOldPass, labelNewPass, labelConfirmPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxHoTen = new TextBox();
            comboBoxGioiTinh = new ComboBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            pictureBoxAvatar = new PictureBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxMoTa = new TextBox();
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxConfirmPass = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            labelHoTen = new Label();
            labelGioiTinh = new Label();
            labelNgaySinh = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelMoTa = new Label();
            labelOldPass = new Label();
            labelNewPass = new Label();
            labelConfirmPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(150, 20);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(100, 27);
            textBoxHoTen.TabIndex = 1;
            // 
            // comboBoxGioiTinh
            // 
            comboBoxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBoxGioiTinh.Location = new Point(150, 60);
            comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            comboBoxGioiTinh.Size = new Size(121, 28);
            comboBoxGioiTinh.TabIndex = 3;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePickerNgaySinh.Location = new Point(150, 100);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(200, 27);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(400, 20);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(120, 120);
            pictureBoxAvatar.TabIndex = 6;
            pictureBoxAvatar.TabStop = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(150, 140);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(150, 180);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 27);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(150, 220);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 27);
            textBoxAddress.TabIndex = 12;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Location = new Point(150, 260);
            textBoxMoTa.Multiline = true;
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.Size = new Size(300, 60);
            textBoxMoTa.TabIndex = 14;
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Location = new Point(150, 340);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.PasswordChar = '*';
            textBoxOldPass.Size = new Size(100, 27);
            textBoxOldPass.TabIndex = 16;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(150, 380);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PasswordChar = '*';
            textBoxNewPass.Size = new Size(100, 27);
            textBoxNewPass.TabIndex = 18;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(150, 420);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Size = new Size(100, 27);
            textBoxConfirmPass.TabIndex = 20;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(150, 470);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(250, 470);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // labelHoTen
            // 
            labelHoTen.Location = new Point(30, 20);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(100, 23);
            labelHoTen.TabIndex = 0;
            labelHoTen.Text = "Họ tên";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.Location = new Point(30, 60);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(100, 23);
            labelGioiTinh.TabIndex = 2;
            labelGioiTinh.Text = "Giới tính";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.Location = new Point(30, 100);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(100, 23);
            labelNgaySinh.TabIndex = 4;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(30, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 23);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(30, 180);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 23);
            labelPhone.TabIndex = 9;
            labelPhone.Text = "Số điện thoại";
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(30, 220);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(100, 23);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "Địa chỉ";
            // 
            // labelMoTa
            // 
            labelMoTa.Location = new Point(30, 260);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(100, 23);
            labelMoTa.TabIndex = 13;
            labelMoTa.Text = "Mô tả";
            // 
            // labelOldPass
            // 
            labelOldPass.Location = new Point(30, 340);
            labelOldPass.Name = "labelOldPass";
            labelOldPass.Size = new Size(100, 23);
            labelOldPass.TabIndex = 15;
            labelOldPass.Text = "Mật khẩu hiện tại";
            // 
            // labelNewPass
            // 
            labelNewPass.Location = new Point(30, 380);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(100, 23);
            labelNewPass.TabIndex = 17;
            labelNewPass.Text = "Mật khẩu mới";
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.Location = new Point(30, 420);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(100, 23);
            labelConfirmPass.TabIndex = 19;
            labelConfirmPass.Text = "Xác nhận mật khẩu";
            // 
            // fEditUser
            // 
            ClientSize = new Size(600, 530);
            Controls.Add(labelHoTen);
            Controls.Add(textBoxHoTen);
            Controls.Add(labelGioiTinh);
            Controls.Add(comboBoxGioiTinh);
            Controls.Add(labelNgaySinh);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(labelMoTa);
            Controls.Add(textBoxMoTa);
            Controls.Add(labelOldPass);
            Controls.Add(textBoxOldPass);
            Controls.Add(labelNewPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(labelConfirmPass);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Name = "fEditUser";
            Text = "Chỉnh sửa thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
