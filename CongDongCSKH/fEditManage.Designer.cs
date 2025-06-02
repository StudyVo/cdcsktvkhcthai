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

            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar)).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(180, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 32);
            lblTitle.Text = "CHỈNH SỬA THÔNG TIN QUẢN TRỊ";

            // Label & Control positions
            int labelX = 40;
            int inputX = 180;
            int labelWidth = 130;
            int inputWidth = 300;
            int startY = 80;
            int spacingY = 40;

            // lblHoTen
            lblHoTen.SetBounds(labelX, startY + spacingY * 0, labelWidth, 25);
            lblHoTen.Text = "Họ tên:";
            txtHoTen.SetBounds(inputX, startY + spacingY * 0, inputWidth, 27);

            // lblEmail
            lblEmail.SetBounds(labelX, startY + spacingY * 1, labelWidth, 25);
            lblEmail.Text = "Email:";
            txtEmail.SetBounds(inputX, startY + spacingY * 1, inputWidth, 27);

            // lblGioiTinh
            lblGioiTinh.SetBounds(labelX, startY + spacingY * 2, labelWidth, 25);
            lblGioiTinh.Text = "Giới tính:";
            cbGioiTinh.SetBounds(inputX, startY + spacingY * 2, inputWidth, 27);
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });

            // lblNgaySinh
            lblNgaySinh.SetBounds(labelX, startY + spacingY * 3, labelWidth, 25);
            lblNgaySinh.Text = "Ngày sinh:";
            dtpNgaySinh.SetBounds(inputX, startY + spacingY * 3, inputWidth, 27);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            // lblMoTa
            lblMoTa.SetBounds(labelX, startY + spacingY * 4, labelWidth, 25);
            lblMoTa.Text = "Mô tả:";
            txtMoTa.SetBounds(inputX, startY + spacingY * 4, inputWidth, 60);
            txtMoTa.Multiline = true;

            // lblMatKhauCu
            lblMatKhauCu.SetBounds(labelX, startY + spacingY * 6, labelWidth, 25);
            lblMatKhauCu.Text = "Mật khẩu cũ:";
            txtMatKhauCu.SetBounds(inputX, startY + spacingY * 6, inputWidth, 27);
            txtMatKhauCu.UseSystemPasswordChar = true;

            // lblMatKhauMoi
            lblMatKhauMoi.SetBounds(labelX, startY + spacingY * 7, labelWidth, 25);
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            txtMatKhauMoi.SetBounds(inputX, startY + spacingY * 7, inputWidth, 27);
            txtMatKhauMoi.UseSystemPasswordChar = true;

            // lblXacNhanMatKhauMoi
            lblXacNhanMatKhauMoi.SetBounds(labelX, startY + spacingY * 8, labelWidth + 10, 25);
            lblXacNhanMatKhauMoi.Text = "Xác nhận mật khẩu:";
            txtXacNhanMatKhauMoi.SetBounds(inputX, startY + spacingY * 8, inputWidth, 27);
            txtXacNhanMatKhauMoi.UseSystemPasswordChar = true;

            // Avatar PictureBox
            pictureBoxAvatar.SetBounds(520, startY, 140, 140);
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // Button chọn ảnh
            btnChonAnh.SetBounds(520, startY + 150, 140, 30);
            btnChonAnh.Text = "Chọn ảnh đại diện";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += new EventHandler(this.btnChonAnh_Click);

            // Button Lưu
            btnLuu.SetBounds(200, startY + spacingY * 10, 120, 35);
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += new EventHandler(this.btnLuu_Click);

            // Button Hủy
            btnHuy.SetBounds(350, startY + spacingY * 10, 120, 35);
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += new EventHandler(this.btnHuy_Click);

            // fEditManage Form
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(720, startY + spacingY * 11 + 40);
            this.Controls.AddRange(new Control[]
            {
                lblTitle,
                lblHoTen, txtHoTen,
                lblEmail, txtEmail,
                lblGioiTinh, cbGioiTinh,
                lblNgaySinh, dtpNgaySinh,
                lblMoTa, txtMoTa,
                lblMatKhauCu, txtMatKhauCu,
                lblMatKhauMoi, txtMatKhauMoi,
                lblXacNhanMatKhauMoi, txtXacNhanMatKhauMoi,
                pictureBoxAvatar, btnChonAnh,
                btnLuu, btnHuy
            });

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fEditManage";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin quản trị viên";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
