namespace CongDongCSKH
{
    partial class fEditManage
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
            lblTitle = new Label();
            lblHoTen = new Label();
            lblEmail = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblMoTa = new Label();
            lblMatKhauCu = new Label();
            lblMatKhauMoi = new Label();
            lblXacNhanMatKhauMoi = new Label();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            cbGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtMoTa = new TextBox();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhauMoi = new TextBox();
            pictureBoxAvatar = new PictureBox();
            btnChonAnh = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(212, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHỈNH SỬA THÔNG TIN QUẢN TRỊ";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(40, 80);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(104, 25);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(40, 201);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(104, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(40, 163);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(104, 25);
            lblGioiTinh.TabIndex = 5;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(40, 121);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(104, 25);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblMoTa
            // 
            lblMoTa.Location = new Point(40, 241);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(104, 25);
            lblMoTa.TabIndex = 9;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.Location = new Point(528, 244);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(130, 25);
            lblMatKhauCu.TabIndex = 11;
            lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.Location = new Point(528, 280);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(130, 25);
            lblMatKhauMoi.TabIndex = 13;
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblXacNhanMatKhauMoi
            // 
            lblXacNhanMatKhauMoi.Location = new Point(528, 313);
            lblXacNhanMatKhauMoi.Name = "lblXacNhanMatKhauMoi";
            lblXacNhanMatKhauMoi.Size = new Size(159, 25);
            lblXacNhanMatKhauMoi.TabIndex = 15;
            lblXacNhanMatKhauMoi.Text = "Xác nhận mật khẩu:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(147, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(300, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 4;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGioiTinh.Location = new Point(147, 160);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(300, 28);
            cbGioiTinh.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(147, 119);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(300, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(147, 241);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(300, 224);
            txtMoTa.TabIndex = 10;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(699, 244);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(162, 27);
            txtMatKhauCu.TabIndex = 12;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(699, 277);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(162, 27);
            txtMatKhauMoi.TabIndex = 14;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhauMoi
            // 
            txtXacNhanMatKhauMoi.Location = new Point(699, 310);
            txtXacNhanMatKhauMoi.Name = "txtXacNhanMatKhauMoi";
            txtXacNhanMatKhauMoi.Size = new Size(162, 27);
            txtXacNhanMatKhauMoi.TabIndex = 16;
            txtXacNhanMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(699, 77);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(162, 151);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 17;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(528, 80);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(140, 30);
            btnChonAnh.TabIndex = 18;
            btnChonAnh.Text = "Chọn ảnh đại diện";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.Location = new Point(548, 430);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 35);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Location = new Point(699, 430);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 35);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // fEditManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 549);
            Controls.Add(lblTitle);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGioiTinh);
            Controls.Add(cbGioiTinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(lblMatKhauCu);
            Controls.Add(txtMatKhauCu);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblXacNhanMatKhauMoi);
            Controls.Add(txtXacNhanMatKhauMoi);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnChonAnh);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fEditManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin quản trị viên";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHoTen;
        private Label lblEmail;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblMoTa;
        private Label lblMatKhauCu;
        private Label lblMatKhauMoi;
        private Label lblXacNhanMatKhauMoi;

        private TextBox txtHoTen;
        private TextBox txtEmail;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMoTa;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhauMoi;

        private PictureBox pictureBoxAvatar;
        private Button btnChonAnh;
        private Button btnLuu;
        private Button btnHuy;
    }
}
