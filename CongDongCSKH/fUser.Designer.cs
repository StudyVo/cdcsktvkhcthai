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
            labelTitle = new Label();
            labelHoTen = new Label();
            labelGioiTinh = new Label();
            labelNgaySinh = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            textBoxName = new TextBox();
            comboBoxGender = new ComboBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            pictureBoxAvatar = new PictureBox();
            buttonEdit = new Button();
            buttonLogout = new Button();
            buttonMessage = new Button();
            buttonChatbot = new Button();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            btnTaobaidang = new Button();
            bnTaonhom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(150, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(350, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÔNG TIN NGƯỜI DÙNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(40, 80);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(57, 20);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(40, 120);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(68, 20);
            labelGioiTinh.TabIndex = 3;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(40, 160);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(77, 20);
            labelNgaySinh.TabIndex = 5;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(40, 200);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(40, 230);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 20);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(40, 260);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(58, 20);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Địa chỉ:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Enabled = false;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBoxGender.Location = new Point(140, 117);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(250, 28);
            comboBoxGender.TabIndex = 4;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(140, 157);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(250, 27);
            dateTimePickerNgaySinh.TabIndex = 6;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(430, 80);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(160, 160);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 10;
            pictureBoxAvatar.TabStop = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Yellow;
            buttonEdit.Location = new Point(240, 381);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 35);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Sửa thông tin";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Location = new Point(430, 381);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(150, 35);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Đăng xuất";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonMessage
            // 
            buttonMessage.BackColor = Color.Cyan;
            buttonMessage.Location = new Point(40, 381);
            buttonMessage.Name = "buttonMessage";
            buttonMessage.Size = new Size(150, 35);
            buttonMessage.TabIndex = 13;
            buttonMessage.Text = "Nhắn tin";
            buttonMessage.UseVisualStyleBackColor = false;
            buttonMessage.Click += buttonMessage_Click;
            // 
            // buttonChatbot
            // 
            buttonChatbot.BackColor = Color.LightSteelBlue;
            buttonChatbot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonChatbot.Location = new Point(41, 435);
            buttonChatbot.Name = "buttonChatbot";
            buttonChatbot.Size = new Size(539, 35);
            buttonChatbot.TabIndex = 14;
            buttonChatbot.Text = "Nhắn tin với Chatbot";
            buttonChatbot.UseVisualStyleBackColor = false;
            buttonChatbot.Click += buttonChatbot_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(140, 198);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(251, 27);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(139, 228);
            textBoxPhone.Margin = new Padding(2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(251, 27);
            textBoxPhone.TabIndex = 16;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(140, 260);
            textBoxAddress.Margin = new Padding(2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(251, 27);
            textBoxAddress.TabIndex = 17;
            // 
            // btnTaobaidang
            // 
            btnTaobaidang.BackColor = Color.Lime;
            btnTaobaidang.Location = new Point(430, 260);
            btnTaobaidang.Margin = new Padding(2);
            btnTaobaidang.Name = "btnTaobaidang";
            btnTaobaidang.Size = new Size(150, 39);
            btnTaobaidang.TabIndex = 18;
            btnTaobaidang.Text = "Tạo bài đăng";
            btnTaobaidang.UseVisualStyleBackColor = false;
            btnTaobaidang.Click += btnTaobaidang_Click;
            // 
            // bnTaonhom
            // 
            bnTaonhom.BackColor = Color.Lime;
            bnTaonhom.Location = new Point(430, 303);
            bnTaonhom.Margin = new Padding(2);
            bnTaonhom.Name = "bnTaonhom";
            bnTaonhom.Size = new Size(150, 38);
            bnTaonhom.TabIndex = 19;
            bnTaonhom.Text = "Tạo nhóm/tổ chức";
            bnTaonhom.UseVisualStyleBackColor = false;
            bnTaonhom.Click += bnTaonhom_Click;
            // 
            // fUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 497);
            Controls.Add(bnTaonhom);
            Controls.Add(btnTaobaidang);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelTitle);
            Controls.Add(labelHoTen);
            Controls.Add(textBoxName);
            Controls.Add(labelGioiTinh);
            Controls.Add(comboBoxGender);
            Controls.Add(labelNgaySinh);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelAddress);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(buttonEdit);
            Controls.Add(buttonLogout);
            Controls.Add(buttonMessage);
            Controls.Add(buttonChatbot);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin người dùng";
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

        private TextBox textBoxName;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerNgaySinh;

        private PictureBox pictureBoxAvatar;
        private Button buttonEdit;
        private Button buttonLogout;
        private Button buttonMessage;
        private Button buttonChatbot;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Button btnTaobaidang;
        private Button bnTaonhom;
    }
}
