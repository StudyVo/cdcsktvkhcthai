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
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxConfirmPass = new TextBox();
            pictureBoxAvatar = new PictureBox();
            btnChonAnh = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            textBoxMoTa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(180, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(495, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHoTen
            // 
            labelHoTen.Location = new Point(50, 75);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(95, 25);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.Location = new Point(50, 108);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(79, 25);
            labelGioiTinh.TabIndex = 2;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.Location = new Point(50, 141);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(79, 25);
            labelNgaySinh.TabIndex = 3;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(50, 175);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(95, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(50, 211);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(102, 25);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(50, 244);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(95, 25);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Địa chỉ:";
            // 
            // labelMoTa
            // 
            labelMoTa.Location = new Point(50, 278);
            labelMoTa.Name = "labelMoTa";
            labelMoTa.Size = new Size(95, 25);
            labelMoTa.TabIndex = 7;
            labelMoTa.Text = "Mô tả:";
            labelMoTa.Click += labelMoTa_Click;
            // 
            // labelOldPass
            // 
            labelOldPass.Location = new Point(496, 283);
            labelOldPass.Name = "labelOldPass";
            labelOldPass.Size = new Size(120, 25);
            labelOldPass.TabIndex = 8;
            labelOldPass.Text = "Mật khẩu hiện tại:";
            // 
            // labelNewPass
            // 
            labelNewPass.Location = new Point(496, 321);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(120, 25);
            labelNewPass.TabIndex = 9;
            labelNewPass.Text = "Mật khẩu mới:";
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.Location = new Point(496, 357);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(140, 25);
            labelConfirmPass.TabIndex = 10;
            labelConfirmPass.Text = "Xác nhận mật khẩu:";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(152, 74);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(280, 27);
            textBoxHoTen.TabIndex = 11;
            // 
            // comboBoxGioiTinh
            // 
            comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBoxGioiTinh.Location = new Point(152, 107);
            comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            comboBoxGioiTinh.Size = new Size(280, 28);
            comboBoxGioiTinh.TabIndex = 12;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(152, 141);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(280, 27);
            dateTimePickerNgaySinh.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(152, 174);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(280, 27);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(152, 207);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(280, 27);
            textBoxPhone.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(152, 242);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(280, 27);
            textBoxAddress.TabIndex = 16;
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Location = new Point(658, 280);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.Size = new Size(204, 27);
            textBoxOldPass.TabIndex = 18;
            textBoxOldPass.UseSystemPasswordChar = true;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(658, 318);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(204, 27);
            textBoxNewPass.TabIndex = 19;
            textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(658, 355);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.Size = new Size(204, 27);
            textBoxConfirmPass.TabIndex = 20;
            textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(658, 72);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(204, 197);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 21;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(496, 72);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(140, 30);
            btnChonAnh.TabIndex = 22;
            btnChonAnh.Text = "Chọn ảnh đại diện";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.Location = new Point(536, 444);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 35);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Location = new Point(658, 444);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 35);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Location = new Point(152, 280);
            textBoxMoTa.Multiline = true;
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.Size = new Size(280, 199);
            textBoxMoTa.TabIndex = 25;
            // 
            // fEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 510);
            Controls.Add(textBoxMoTa);
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
            Controls.Add(textBoxOldPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnChonAnh);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private TextBox textBoxOldPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxConfirmPass;

        private PictureBox pictureBoxAvatar;
        private Button btnChonAnh;
        private Button btnLuu;
        private Button btnHuy;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textBoxMoTa;
    }
}