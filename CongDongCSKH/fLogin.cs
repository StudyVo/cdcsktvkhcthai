using System;
using System.Linq;
using System.Windows.Forms;
using CongDongCSKH.Models; // Import để sử dụng User
using Microsoft.EntityFrameworkCore;

namespace CongDongCSKH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo sau này nếu cần
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dangKyForm = new fDangky())
            {
                dangKyForm.ShowDialog();
                // Sau khi đăng ký xong, tự quay lại form đăng nhập hiện tại
            }
        }

        private void btLoginManager_Click(object sender, EventArgs e)
        {
            using (var managerForm = new fLoginManager())
            {
                managerForm.ShowDialog();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string input = txtName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(input))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập hoặc email", txtName, 0, -20, 3000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }

            try
            {
                using (var db = new EFDbContext())
                {
                    var user = db.Users
                        .FirstOrDefault(u =>
                            (u.TenDn == input || u.Email == input)
                            && u.Password == password);

                    if (user != null)
                    {
                        // Đăng nhập thành công
                        this.Hide();
                        var userForm = new fUser(user.Id);
                        userForm.FormClosed += (s, args) => this.Show(); // Trở về sau khi user đóng form
                        userForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập/email hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gọi lại đăng nhập từ nút phụ
        private void btnĐăngnhập_Click(object sender, EventArgs e)
        {
            btLogin_Click(sender, e);
        }

        // Nút test nhanh (nếu còn dùng)
        private void button1_Click(object sender, EventArgs e)
        {
            int testUserId = 1;
            var userForm = new fUser(testUserId);
            userForm.ShowDialog();
        }
    }
}
