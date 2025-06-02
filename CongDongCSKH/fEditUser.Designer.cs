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

            // labelTitle
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(180, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(420, 35);
            labelTitle.Text = "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Các Label
            int leftLabelX = 50;
            int topStartY = 70;
            int spacingY = 40;

            labelHoTen.SetBounds(leftLabelX, topStartY + spacingY * 0, 120, 25);
            labelHoTen.Text = "Họ tên:";

            labelGioiTinh.SetBounds(leftLabelX, topStartY + spacingY * 1, 120, 25);
            labelGioiTinh.Text = "Giới tính:";

            labelNgaySinh.SetBounds(leftLabelX, topStartY + spacingY * 2, 120, 25);
            labelNgaySinh.Text = "Ngày sinh:";

            labelEmail.SetBounds(leftLabelX, topStartY + spacingY * 3, 120, 25);
            labelEmail.Text = "Email:";

            labelPhone.SetBounds(leftLabelX, topStartY + spacingY * 4, 120, 25);
            labelPhone.Text = "Số điện thoại:";

            labelAddress.SetBounds(leftLabelX, topStartY + spacingY * 5, 120, 25);
            labelAddress.Text = "Địa chỉ:";

            labelMoTa.SetBounds(leftLabelX, topStartY + spacingY * 6, 120, 25);
            labelMoTa.Text = "Mô tả:";

            labelOldPass.SetBounds(leftLabelX, topStartY + spacingY * 7, 120, 25);
            labelOldPass.Text = "Mật khẩu hiện tại:";

            labelNewPass.SetBounds(leftLabelX, topStartY + spacingY * 8, 120, 25);
            labelNewPass.Text = "Mật khẩu mới:";

            labelConfirmPass.SetBounds(leftLabelX, topStartY + spacingY * 9, 140, 25);
            labelConfirmPass.Text = "Xác nhận mật khẩu:";

            // Các TextBox và Controls
            int inputX = 200;
            int inputWidth = 280;

            textBoxHoTen.SetBounds(inputX, topStartY + spacingY * 0, inputWidth, 27);
            comboBoxGioiTinh.SetBounds(inputX, topStartY + spacingY * 1, inputWidth, 27);
            comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });

            dateTimePickerNgaySinh.SetBounds(inputX, topStartY + spacingY * 2, inputWidth, 27);
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;

            textBoxEmail.SetBounds(inputX, topStartY + spacingY * 3, inputWidth, 27);
            textBoxPhone.SetBounds(inputX, topStartY + spacingY * 4, inputWidth, 27);
            textBoxAddress.SetBounds(inputX, topStartY + spacingY * 5, inputWidth, 27);
            textBoxMoTa.SetBounds(inputX, topStartY + spacingY * 6, inputWidth, 27);
            textBoxOldPass.SetBounds(inputX, topStartY + spacingY * 7, inputWidth, 27);
            textBoxOldPass.UseSystemPasswordChar = true;

            textBoxNewPass.SetBounds(inputX, topStartY + spacingY * 8, inputWidth, 27);
            textBoxNewPass.UseSystemPasswordChar = true;

            textBoxConfirmPass.SetBounds(inputX, topStartY + spacingY * 9, inputWidth, 27);
            textBoxConfirmPass.UseSystemPasswordChar = true;

            // Avatar
            pictureBoxAvatar.SetBounds(520, topStartY, 140, 140);
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // Button Chọn ảnh
            btnChonAnh.SetBounds(520, topStartY + 150, 140, 30);
            btnChonAnh.Text = "Chọn ảnh đại diện";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += new EventHandler(this.btnChonAnh_Click);

            // Buttons Lưu & Hủy
            int buttonY = topStartY + spacingY * 10 + 20;
            btnLuu.SetBounds(200, buttonY, 100, 35);
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += new EventHandler(this.btnLuu_Click);

            btnHuy.SetBounds(350, buttonY, 100, 35);
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += new EventHandler(this.btnHuy_Click);

            // Form
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(720, buttonY + 80);
            this.Controls.Add(labelTitle);

            this.Controls.AddRange(new Control[]
            {
                labelHoTen, labelGioiTinh, labelNgaySinh, labelEmail, labelPhone,
                labelAddress, labelMoTa, labelOldPass, labelNewPass, labelConfirmPass,

                textBoxHoTen, comboBoxGioiTinh, dateTimePickerNgaySinh, textBoxEmail,
                textBoxPhone, textBoxAddress, textBoxMoTa,
                textBoxOldPass, textBoxNewPass, textBoxConfirmPass,

                pictureBoxAvatar, btnChonAnh, btnLuu, btnHuy
            });

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fEditUser";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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