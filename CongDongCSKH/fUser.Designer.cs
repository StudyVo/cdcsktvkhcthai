namespace CongDongCSKH
{
    partial class fUser
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên đang sử dụng
        /// </summary>
        /// <param name="disposing">true nếu cần dispose managed resources</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.labelHoTen = new Label();
            this.labelGioiTinh = new Label();
            this.labelNgaySinh = new Label();
            this.labelEmail = new Label();
            this.labelPhone = new Label();
            this.labelAddress = new Label();

            this.textBoxName = new TextBox();
            this.comboBoxGender = new ComboBox();
            this.dateTimePickerNgaySinh = new DateTimePicker();

            this.pictureBoxAvatar = new PictureBox();
            this.buttonEdit = new Button();
            this.buttonLogout = new Button();
            this.buttonMessage = new Button();
            this.buttonChatbot = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitle.Location = new Point(150, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(350, 35);
            this.labelTitle.Text = "THÔNG TIN NGƯỜI DÙNG";
            this.labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // labelHoTen
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new Point(40, 80);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new Size(57, 20);
            this.labelHoTen.Text = "Họ tên:";

            // textBoxName
            this.textBoxName.Location = new Point(140, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(250, 27);

            // labelGioiTinh
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new Point(40, 120);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new Size(68, 20);
            this.labelGioiTinh.Text = "Giới tính:";

            // comboBoxGender
            this.comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGender.Enabled = false;
            this.comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.comboBoxGender.Location = new Point(140, 117);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new Size(250, 28);

            // labelNgaySinh
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new Point(40, 160);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new Size(77, 20);
            this.labelNgaySinh.Text = "Ngày sinh:";

            // dateTimePickerNgaySinh
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Enabled = false;
            this.dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new Point(140, 157);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new Size(250, 27);

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(40, 200);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(49, 20);
            this.labelEmail.Text = "Email:";

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(40, 230);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(100, 20);
            this.labelPhone.Text = "Số điện thoại:";

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(40, 260);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(58, 20);
            this.labelAddress.Text = "Địa chỉ:";

            // pictureBoxAvatar
            this.pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxAvatar.Location = new Point(430, 80);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new Size(160, 160);
            this.pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // buttonEdit
            this.buttonEdit.Location = new Point(40, 310);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new Size(150, 35);
            this.buttonEdit.Text = "Sửa thông tin";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new EventHandler(this.buttonEdit_Click);

            // buttonLogout
            this.buttonLogout.Location = new Point(210, 310);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new Size(150, 35);
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new EventHandler(this.buttonLogout_Click);

            // buttonMessage
            this.buttonMessage.Location = new Point(380, 310);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new Size(150, 35);
            this.buttonMessage.Text = "Nhắn tin";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new EventHandler(this.buttonMessage_Click);

            // buttonChatbot
            this.buttonChatbot.Location = new Point(40, 360);
            this.buttonChatbot.Name = "buttonChatbot";
            this.buttonChatbot.Size = new Size(490, 35);
            this.buttonChatbot.Text = "Nhắn tin với Chatbot";
            this.buttonChatbot.UseVisualStyleBackColor = true;
            this.buttonChatbot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonChatbot.BackColor = Color.LightSteelBlue;
            this.buttonChatbot.Click += new EventHandler(this.buttonChatbot_Click);

            // fUser
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 420);
            this.Controls.AddRange(new Control[]
            {
                labelTitle,
                labelHoTen, textBoxName,
                labelGioiTinh, comboBoxGender,
                labelNgaySinh, dateTimePickerNgaySinh,
                labelEmail, labelPhone, labelAddress,
                pictureBoxAvatar,
                buttonEdit, buttonLogout, buttonMessage,
                buttonChatbot
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fUser";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thông tin người dùng";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
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

        private TextBox textBoxName;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerNgaySinh;

        private PictureBox pictureBoxAvatar;
        private Button buttonEdit;
        private Button buttonLogout;
        private Button buttonMessage;
        private Button buttonChatbot;
    }
}
