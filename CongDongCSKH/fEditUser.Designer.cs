namespace CongDongCSKH
{
    partial class fEditUser
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
            labelTitle = new Label();
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
            textBoxHoTen = new TextBox();
            comboBoxGioiTinh = new ComboBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxMoTa = new TextBox();
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxConfirmPass = new TextBox();
            pictureBoxAvatar = new PictureBox();
            btnChonAnh = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(225, 25);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(525, 44);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHoTen
            // 
            labelHoTen.Location = new Point(62, 88);
            labelHoTen.Margin = new Padding(4, 0, 4, 0);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(150, 31);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.Location = new Point(62, 88);
            labelGioiTinh.Margin = new Padding(4, 0, 4, 0);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(150, 31);
            labelGioiTinh.TabIndex = 2;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.Location = new Point(62, 88);
            labelNgaySinh.Margin = new Padding(4, 0, 4, 0);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(150, 31);
            labelNgaySinh.TabIndex = 3;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(62, 88);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(150, 31);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(62, 88);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(150, 31);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(62, 88);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(150, 31);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Địa chỉ:";
            // 
            // labelMoTa
            // 
            labelMoTa.Location = new Point(62, 88);
            labelMoTa.Margin = new Padding(4, 0, 4, 0);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(150, 31);
            labelMoTa.TabIndex = 7;
            labelMoTa.Text = "Mô tả:";
            // 
            // labelOldPass
            // 
            labelOldPass.Location = new Point(62, 88);
            labelOldPass.Margin = new Padding(4, 0, 4, 0);
            labelOldPass.Name = "labelOldPass";
            labelOldPass.Size = new Size(150, 31);
            labelOldPass.TabIndex = 8;
            labelOldPass.Text = "Mật khẩu hiện tại:";
            // 
            // labelNewPass
            // 
            labelNewPass.Location = new Point(62, 88);
            labelNewPass.Margin = new Padding(4, 0, 4, 0);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(150, 31);
            labelNewPass.TabIndex = 9;
            labelNewPass.Text = "Mật khẩu mới:";
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.Location = new Point(62, 88);
            labelConfirmPass.Margin = new Padding(4, 0, 4, 0);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(175, 31);
            labelConfirmPass.TabIndex = 10;
            labelConfirmPass.Text = "Xác nhận mật khẩu:";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(377, 360);
            textBoxHoTen.Margin = new Padding(4, 4, 4, 4);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(349, 31);
            textBoxHoTen.TabIndex = 11;
            // 
            // comboBoxGioiTinh
            // 
            comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBoxGioiTinh.Location = new Point(225, 294);
            comboBoxGioiTinh.Margin = new Padding(4, 4, 4, 4);
            comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            comboBoxGioiTinh.Size = new Size(349, 33);
            comboBoxGioiTinh.TabIndex = 12;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(423, 244);
            dateTimePickerNgaySinh.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(349, 31);
            dateTimePickerNgaySinh.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(40, 279);
            textBoxEmail.Margin = new Padding(4, 4, 4, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(349, 31);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(250, 88);
            textBoxPhone.Margin = new Padding(4, 4, 4, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(349, 31);
            textBoxPhone.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(250, 88);
            textBoxAddress.Margin = new Padding(4, 4, 4, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(349, 31);
            textBoxAddress.TabIndex = 16;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Location = new Point(250, 88);
            textBoxMoTa.Margin = new Padding(4, 4, 4, 4);
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.Size = new Size(349, 31);
            textBoxMoTa.TabIndex = 17;
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Location = new Point(250, 88);
            textBoxOldPass.Margin = new Padding(4, 4, 4, 4);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.Size = new Size(349, 31);
            textBoxOldPass.TabIndex = 18;
            textBoxOldPass.UseSystemPasswordChar = true;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(250, 88);
            textBoxNewPass.Margin = new Padding(4, 4, 4, 4);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(349, 31);
            textBoxNewPass.TabIndex = 19;
            textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(250, 88);
            textBoxConfirmPass.Margin = new Padding(4, 4, 4, 4);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.Size = new Size(349, 31);
            textBoxConfirmPass.TabIndex = 20;
            textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(650, 88);
            pictureBoxAvatar.Margin = new Padding(4, 4, 4, 4);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(174, 174);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 21;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(650, 88);
            btnChonAnh.Margin = new Padding(4, 4, 4, 4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(175, 38);
            btnChonAnh.TabIndex = 22;
            btnChonAnh.Text = "Chọn ảnh đại diện";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(250, 88);
            btnLuu.Margin = new Padding(4, 4, 4, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 44);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(438, 88);
            btnHuy.Margin = new Padding(4, 4, 4, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 44);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // fEditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 395);
            Controls.Add(labelTitle);
            Controls.Add(labelHoTen);
            Controls.Add(labelGioiTinh);
            Controls.Add(labelNgaySinh);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelAddress);
            Controls.Add(labelMoTa);
            Controls.Add(labelOldPass);
            Controls.Add(labelNewPass);
            Controls.Add(labelConfirmPass);
            Controls.Add(textBoxHoTen);
            Controls.Add(comboBoxGioiTinh);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxMoTa);
            Controls.Add(textBoxOldPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnChonAnh);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "fEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelHoTen;
        private Label labelGioiTinh;
        private Label labelNgaySinh;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelMoTa;
        private Label labelOldPass;
        private Label labelNewPass;
        private Label labelConfirmPass;

        private TextBox textBoxHoTen;
        private ComboBox comboBoxGioiTinh;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxMoTa;
        private TextBox textBoxOldPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxConfirmPass;

        private PictureBox pictureBoxAvatar;
        private Button btnChonAnh;
        private Button btnLuu;
        private Button btnHuy;
    }
}