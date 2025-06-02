using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CongDongCSKH.Models;

namespace CongDongCSKH
{
    public partial class fDangky : Form
    {
        private readonly EFDbContext db;

        public fDangky()
        {
            InitializeComponent();
            db = new EFDbContext();

            // Thiết lập định dạng ngày sinh
            ngaysinh.Format = DateTimePickerFormat.Custom;
            ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string tenDn = txtTenDn.Text.Trim();

            // Kiểm tra trùng tên đăng nhập hoặc email
            if (db.Users.Any(u => u.TenDn == tenDn))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDn.Focus();
                return;
            }

            if (db.Users.Any(u => u.Email == txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email đã được sử dụng. Vui lòng dùng email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                var newUser = new User
                {
                    TenNguoiDung = txtHoTen.Text.Trim(),
                    TenDn = tenDn,
                    Password = txtPassword.Text.Trim(), // ❗Nên mã hóa trong thực tế
                    Email = txtEmail.Text.Trim(),
                    NgaySinh = ngaysinh.Value
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Quay lại form đăng nhập hiện tại
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra dữ liệu người dùng nhập vào
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                toolTip1.Show("Vui lòng nhập họ và tên", txtHoTen, 0, -20, 3000);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDn.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtTenDn, 0, -20, 3000);
                txtTenDn.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                toolTip1.Show("Vui lòng xác nhận mật khẩu", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                toolTip1.Show("Mật khẩu và xác nhận không khớp", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Vui lòng nhập email", txtEmail, 0, -20, 3000);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                toolTip1.Show("Email không hợp lệ", txtEmail, 0, -20, 3000);
                txtEmail.Focus();
                return false;
            }

            if (ngaysinh.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày sinh không được lớn hơn ngày hiện tại", ngaysinh, 0, -20, 3000);
                ngaysinh.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra định dạng email
        /// </summary>
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
