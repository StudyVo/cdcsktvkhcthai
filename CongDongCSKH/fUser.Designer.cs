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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnTaobaidang = new Button();
            bnTaonhom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(188, 25);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(438, 44);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÔNG TIN NGƯỜI DÙNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(50, 100);
            labelHoTen.Margin = new Padding(4, 0, 4, 0);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(70, 25);
            labelHoTen.TabIndex = 1;
            labelHoTen.Text = "Họ tên:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(50, 150);
            labelGioiTinh.Margin = new Padding(4, 0, 4, 0);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(82, 25);
            labelGioiTinh.TabIndex = 3;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(50, 200);
            labelNgaySinh.Margin = new Padding(4, 0, 4, 0);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(95, 25);
            labelNgaySinh.TabIndex = 5;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(50, 250);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(50, 288);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(121, 25);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(50, 325);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(69, 25);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Địa chỉ:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(175, 96);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(312, 31);
            textBoxName.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Enabled = false;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBoxGender.Location = new Point(175, 146);
            comboBoxGender.Margin = new Padding(4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(312, 33);
            comboBoxGender.TabIndex = 4;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(175, 196);
            dateTimePickerNgaySinh.Margin = new Padding(4);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(312, 31);
            dateTimePickerNgaySinh.TabIndex = 6;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(538, 100);
            pictureBoxAvatar.Margin = new Padding(4);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(200, 200);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 10;
            pictureBoxAvatar.TabStop = false;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(51, 476);
            buttonEdit.Margin = new Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(188, 44);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Sửa thông tin";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(257, 476);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(188, 44);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Đăng xuất";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonMessage
            // 
            buttonMessage.Location = new Point(475, 476);
            buttonMessage.Margin = new Padding(4);
            buttonMessage.Name = "buttonMessage";
            buttonMessage.Size = new Size(188, 44);
            buttonMessage.TabIndex = 13;
            buttonMessage.Text = "Nhắn tin";
            buttonMessage.UseVisualStyleBackColor = true;
            buttonMessage.Click += buttonMessage_Click;
            // 
            // buttonChatbot
            // 
            buttonChatbot.BackColor = Color.LightSteelBlue;
            buttonChatbot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonChatbot.Location = new Point(51, 544);
            buttonChatbot.Margin = new Padding(4);
            buttonChatbot.Name = "buttonChatbot";
            buttonChatbot.Size = new Size(612, 44);
            buttonChatbot.TabIndex = 14;
            buttonChatbot.Text = "Nhắn tin với Chatbot";
            buttonChatbot.UseVisualStyleBackColor = false;
            buttonChatbot.Click += buttonChatbot_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 31);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 31);
            textBox3.TabIndex = 17;
            // 
            // btnTaobaidang
            // 
            btnTaobaidang.Location = new Point(538, 344);
            btnTaobaidang.Name = "btnTaobaidang";
            btnTaobaidang.Size = new Size(187, 34);
            btnTaobaidang.TabIndex = 18;
            btnTaobaidang.Text = "Tạo bài đăng";
            btnTaobaidang.UseVisualStyleBackColor = true;
            btnTaobaidang.Click += btnTaobaidang_Click;
            // 
            // bnTaonhom
            // 
            bnTaonhom.Location = new Point(538, 394);
            bnTaonhom.Name = "bnTaonhom";
            bnTaonhom.Size = new Size(187, 34);
            bnTaonhom.TabIndex = 19;
            bnTaonhom.Text = "Tạo nhóm/tổ chức";
            bnTaonhom.UseVisualStyleBackColor = true;
            bnTaonhom.Click += bnTaonhom_Click;
            // 
            // fUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 621);
            Controls.Add(bnTaonhom);
            Controls.Add(btnTaobaidang);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Margin = new Padding(4);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnTaobaidang;
        private Button bnTaonhom;
    }
}
