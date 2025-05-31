using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            db = new EFDbContext(); // Khởi tạo DbContext
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(txtName.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtName, 0, -20, 3000);
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                toolTip1.Show("Vui lòng xác nhận mật khẩu", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                toolTip1.Show("Mật khẩu và xác nhận mật khẩu không khớp", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return;
            }

            // Kiểm tra trùng tên đăng nhập
            if (db.Users.Any(u => u.TenDn == txtName.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
                // Tạo mới User
                var newUser = new User
                {
                    TenDn = txtName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    NgaySinh = ngaysinh.Value
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form đăng nhập và đóng form hiện tại
                fLogin loginForm = new fLogin();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}